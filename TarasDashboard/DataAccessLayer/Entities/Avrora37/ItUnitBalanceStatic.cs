using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItUnitBalanceStatic
    {
        public DateTime Дата { get; set; }
        public decimal? _21НеОбработанныеРаспределенияВсегоЮнитов { get; set; }
        public decimal? _22НеОбработанныеРаспределенияЮнитовНаТт { get; set; }
        public decimal? _23НеОбработанныеРаспределенияВсегоКВоАртикулов { get; set; }
        public decimal? _24НеОбработанныеРаспределенияКВоСтрокЗаказаНаТт { get; set; }
        public decimal? _25НеОбработанныеРаспределенияВсегоСуммаЦз { get; set; }
        public decimal? _31ОбработаноВсегоЮнитовЗаСуткиС800До800 { get; set; }
        public decimal? _32ОбработаноЮнитовНаТтЗаСуткиС800До800 { get; set; }
        public int? _33ОбработаноКВоАртикуловНаТтЗаСуткиС800До800 { get; set; }
        public int? _34ОбработаноКВоСтрокЗаказаНаТтЗаСуткиС800До800 { get; set; }
        public decimal? _35ОбработаноВсегоСуммаЦзЗаСуткиС800До800 { get; set; }
        public decimal? _36ОбработаноСуммаЦзНаТтЗаСуткиС800До800 { get; set; }
        public decimal? _51ОжидаемоеПоступлениеВсегоЮнитов { get; set; }
        public decimal? _52ОжидаемоеПоступлениеВсегоКВоАртикулов { get; set; }
        public decimal? _53ОжидаемоеПоступлениеВсегоСуммаЦз { get; set; }
        public decimal? _61РаспределеноВсегоЮнитов { get; set; }
        public int? _62РаспределеноВсегоКВоАртикулов { get; set; }
        public decimal? _63РаспределеноВсегоСуммаЦз { get; set; }
        public decimal? _71ФактическиПоступилоВсегоЮнитов { get; set; }
        public int? _72ФактическиПоступилоВсегоКВоАртикулов { get; set; }
        public decimal? _73ФактическиПоступилоВсегоСуммаЦз { get; set; }
        public decimal? _81НаСколькоДнейОбработкиТовараВсегоЮнитов { get; set; }
        public decimal? _82НаСколькоДнейОбработкиТовараЮнитовНаТт { get; set; }
        public decimal? _83НаСколькоДнейОбработкиТовараВсегоКВоАртикулов { get; set; }
        public decimal? _84НаСколькоДнейОбработкиТовараКВоСтрокЗаказаНаТт { get; set; }
        public decimal? _85НаСколькоДнейОбработкиТовараВсегоСуммаЦз { get; set; }
        public decimal? _91СреднедневнаяОбработкаВсегоЮнитов { get; set; }
        public decimal? _92СреднедневнаяОбработкаЮнитовНаТт { get; set; }
        public decimal? _93СреднедневнаяОбработкаКВоАртикуловНаТт { get; set; }
        public decimal? _94СреднедневнаяОбработкаКВоСтрокЗаказаНаТт { get; set; }
        public decimal? _95СреднедневнаяОбработкаВсегоСуммаЦз { get; set; }
        public decimal? _96СреднедневнаяОбработкаСуммаЦзНаТт { get; set; }
    }
}
