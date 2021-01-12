using DSPU_EDU_PROJ.Models;
using System.Collections.Generic;

namespace DSPU_EDU_PROJ
{
    public static class Data
    {
        public static List<NameIndexModel> Ir = new List<NameIndexModel>
        {
            new NameIndexModel{Name="Перший (бакалаврський) рівень", Index = 1},
            new NameIndexModel{Name="Другий (магістерський) рівень", Index = 1.3},
            new NameIndexModel{Name="Третій (осітньо-науковий/освітньо-творчий рівень)", Index = 0.8},
            new NameIndexModel{Name="Науковий рівень", Index = 0.5},
        };

        public static List<NameIndexModel> If = new List<NameIndexModel>
        {
            new NameIndexModel{Name="Денна форма здобуття освіти", Index = 1},
            new NameIndexModel{Name="Заочна форма здобуття освіти", Index = 0.35},
            new NameIndexModel{Name="Вечірня форма здобутя освіти для здобувачів освітньо-наукового/освітньо-творчого рівня", Index = 0.85},
        };

        public static List<NameIndexModel> Is = new List<NameIndexModel>
        {
            new NameIndexModel{Name="011 Освітні, педагогічні науки", Index = 1.2},
            new NameIndexModel{Name="012 Дошкільна освіта", Index = 1.2},
            new NameIndexModel{Name="013 Початкова освіта", Index = 1.2},
            new NameIndexModel{Name="015.38 Професійна освіта (Транспорт)", Index = 1.2},
            new NameIndexModel{Name="014.01 Середня освіта (Українська мова і література)", Index = 1.2},
            new NameIndexModel{Name="014.02 Середня освіта (Мова і література (англійська))", Index = 1.2},
            new NameIndexModel{Name="014.02 Середня освіта (Мова і література (німецька))", Index = 1.2},
            new NameIndexModel{Name="014.02 Середня освіта (Мова і література (французька))", Index = 1.2},
            new NameIndexModel{Name="014.03 Середня освіта (Історія)", Index = 1.2},
            new NameIndexModel{Name="014.04 Середня освіта (Математика)", Index = 1.2},
            new NameIndexModel{Name="014.05 Середня освіта (Біологія та здоров'я людини)", Index = 1.2},
            new NameIndexModel{Name="014.06 Середня освіта (Хімія)", Index = 1.2},
            new NameIndexModel{Name="014.07 Середня освіта (Географія)", Index = 1.2},
            new NameIndexModel{Name="014.08 Середня освіта (Фізика)", Index = 1.2},
            new NameIndexModel{Name="014.09 Середня освіта (Інформатика)", Index = 1.2},
            new NameIndexModel{Name="014.10 Середня освіта (Трудове навчання та технології)", Index = 1.2},
            new NameIndexModel{Name="014.11 Середня освіта (Фізична культура)", Index = 1.2},
            new NameIndexModel{Name="014.13 Середня освіта (Музичне мистецтво)", Index = 3},
            new NameIndexModel{Name="025 Музичне мистецтво", Index = 3},
            new NameIndexModel{Name="032 Історія та археологія", Index = 1},
            new NameIndexModel{Name="033 Філософія", Index = 1},
            new NameIndexModel{Name="035 Філологія", Index = 1.2},
            new NameIndexModel{Name="051 Економіка", Index = 1},
            new NameIndexModel{Name="053 Психологія", Index = 1},
            new NameIndexModel{Name="054 Соціологія", Index = 1},
            new NameIndexModel{Name="073 Менеджмент", Index = 1},
            new NameIndexModel{Name="091 Біологія", Index = 1.6},
            new NameIndexModel{Name="101 Екологія", Index = 1.2},
            new NameIndexModel{Name="104 Фізика та астрономія", Index = 1.6},
            new NameIndexModel{Name="105 Прикладна фізика та наноматеріали", Index = 1.6},
            new NameIndexModel{Name="106 Географія", Index = 1.2},
            new NameIndexModel{Name="111 Математика", Index = 1.2},
            new NameIndexModel{Name="122 Комп'ютерні науки", Index = 1.2},
            new NameIndexModel{Name="227 Фізична терапія, ерготерапія", Index = 2},
            new NameIndexModel{Name="231 Соціальна робота", Index = 1},
        };
    }
}
