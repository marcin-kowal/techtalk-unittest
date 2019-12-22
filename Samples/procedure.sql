(...)
        if p_obiekty.count > 0 then
            for i IN p_obiekty.first..p_obiekty.last loop
                if p_obiekty.exists(i) then

                    if p_obiekty(i).zostaw = 1 and p_obiekty(i).wykluczenie <> 1 then
                       if p_obiekty(i).zro_id > 0  then

                         insert into CS_INT_KONF_DANE_CSPR_TB(dtczas, str_czasu, wartosc,
                                      status, status_r, zro_id, obiekt_id, dtczas_wer,
                                      dtczas_utc, dtczas_wer_utc)
                               select g.data,
                                      g.str_czasu,
                                      nvl(adw.wartosc,0),
                                      nvl(adw.status,2),
                                      nvl(adw.status_r,0),
                                      p_obiekty(i).zro_id,
                                      p_obiekty(i).obiekt,
                                      null/*rWersja.dtczas_wer*/,
                                      ptools.zamien_PL_UTC(g.data, g.str_czasu),
                                      null
                                 from godziny g,
                                      (select /*+ index(dko, adwt_i)*/
                                              dko.*
                                         from alg_dane_wersji_temp dko
                                        where dko.zro_id   = p_obiekty(i).zro_id ) adw
                                where g.data      = adw.dtczas (+)
                                  and g.str_czasu = adw.str_czasu (+);

                       else

                        insert into CS_INT_KONF_DANE_CSPR_TB(dtczas, str_czasu, wartosc,
                                    status, status_r, zro_id, obiekt_id, dtczas_wer,
                                    dtczas_utc, dtczas_wer_utc)
                        select /*+  ORDERED  INDEX (dko, adwt_zro_i)  index(zwr, zrwr_ran_fk_i)*/
                               dko.dtczas, dko.str_czasu, dko.wartosc, dko.status, dko.status_r, dko.zro_id,
                               p_obiekty(i).obiekt, null/*rWersja.dtczas_wer*/, ptools.zamien_PL_UTC(dko.dtczas, dko.str_czasu), null
                        from
                             (select /*+  ORDERED  INDEX (dko1, adwt_zro_i) INDEX(r1, ran_pom_fk_i) index(zwr1, zrwr_ran_fk_i)*/
                                     x.ran_id ran_id,dko1.dtczas dtczas,
                                     MIN(dko1.status*10 + x.pozycja) minsp
                               from (select zwr1.zro_id, zwr1.dtczas_do, zwr1.dtczas_od, zwr1.ran_id, zwr1.pozycja
                                     from  rankingi r1,
                                           zrodla_w_rankingu zwr1
                                      where zwr1.ran_id = r1.id
                                        and r1.pom_id   = p_obiekty(i).pom_id) x,
                                     alg_dane_wersji_temp dko1
                               where dko1.zro_id  = x.zro_id
                                 and dko1.dtczas  > dt_od
                                 and dko1.dtczas <= dt_do
                                 and (x.dtczas_do is null or dko1.dtczas <= x.dtczas_do)
                                 and dko1.dtczas  > x.dtczas_od
                            group by  ran_id, dtczas  ) best_s,
                            zrodla_w_rankingu    zwr,
                            alg_dane_wersji_temp dko
                        where zwr.ran_id = best_s.ran_id
                          and dko.dtczas   = best_s.dtczas
                          and dko.dtczas   > dt_od
                          and dko.dtczas   <= dt_do
                          and zwr.pozycja   = MOD(best_s.minsp,10)
                          and dko.zro_id    = zwr.zro_id
                          and (zwr.dtczas_do is null or best_s.dtczas <= zwr.dtczas_do)
                          and best_s.dtczas > zwr.dtczas_od;

                        end if;
                    end if;
                end if;
            end loop;
        end if;
(...)