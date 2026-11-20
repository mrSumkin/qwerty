using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020007C7 RID: 1991
public static class dag
{
	// Token: 0x060031FE RID: 12798 RVA: 0x001319E0 File Offset: 0x0012FBE0
	public static void a()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			string[] array = null;
			Dictionary<string, int> dictionary = serviceOrThrow.aqu().r()["arenaStats"] as Dictionary<string, int>;
			if (dictionary != null)
			{
				foreach (object[] array2 in new List<object[]>
				{
					new object[]
					{
						eyy.ar,
						1,
						"Бессмертный",
						"Бессмертная"
					},
					new object[]
					{
						eyy.at,
						1,
						"Фантом",
						"Призрак"
					},
					new object[]
					{
						eyy.au,
						1,
						"Ангел смерти",
						"Ангел смерти"
					},
					new object[]
					{
						eyy.a0,
						1,
						"Тра-та-та",
						"Леди тра-та-та"
					},
					new object[]
					{
						eyy.an,
						1,
						"Истязание",
						"Агония"
					},
					new object[]
					{
						eyy.aq,
						5,
						"Брутал",
						"Бруталетта"
					},
					new object[]
					{
						eyy.az,
						1,
						"Динамит",
						"Бомба"
					},
					new object[]
					{
						eyy.bt,
						11,
						"Адреналин",
						"Спешка"
					},
					new object[]
					{
						eyy.bu,
						11,
						"Наркотик",
						"Наркота"
					},
					new object[]
					{
						eyy.bx,
						6,
						"Мистер мороз",
						"Снежная королева"
					},
					new object[]
					{
						eyy.by,
						8,
						"Паралич",
						"Кома"
					},
					new object[]
					{
						eyy.b0,
						12,
						"Морфей",
						"Сирена"
					},
					new object[]
					{
						eyy.b1,
						7,
						"Пиромант",
						"Напалм"
					},
					new object[]
					{
						eyy.b4,
						2,
						"Каратель",
						"Судья"
					}
				})
				{
					if (dag.a(dictionary, array2[0] as string) >= (int)array2[1])
					{
						array = new string[]
						{
							array2[2] as string,
							array2[3] as string
						};
						break;
					}
				}
				if (array == null)
				{
					Dictionary<string, string[]> dictionary2 = new Dictionary<string, string[]>();
					dictionary2[eyy.a7] = new string[]
					{
						"Костолом",
						"Отбивная"
					};
					dictionary2[eyy.a8] = new string[]
					{
						"Варвар",
						"Бритва"
					};
					dictionary2[eyy.a9] = new string[]
					{
						"Рубака",
						"Лезвие"
					};
					dictionary2[eyy.ba] = new string[]
					{
						"Колосажатель",
						"Амазонка"
					};
					dictionary2[eyy.bb] = new string[]
					{
						"Кузнец",
						"Наковальня"
					};
					dictionary2[eyy.bc] = new string[]
					{
						"Шквал",
						"Гильза"
					};
					dictionary2[eyy.bd] = new string[]
					{
						"Дезинтегратор",
						"Дезинтеграция"
					};
					dictionary2[eyy.be] = new string[]
					{
						"Растворитель",
						"Растворительница"
					};
					dictionary2[eyy.bf] = new string[]
					{
						"Мистер Бомбастик",
						"Бомбарда"
					};
					dictionary2[eyy.bg] = new string[]
					{
						"Болтомёт",
						"Баллиста"
					};
					dictionary2[eyy.bh] = new string[]
					{
						"Шторм",
						"Гроза"
					};
					dictionary2[eyy.bi] = new string[]
					{
						"Джокер",
						"Ведьма"
					};
					dictionary2[eyy.bj] = new string[]
					{
						"Электро",
						"Электра"
					};
					dictionary2[eyy.bk] = new string[]
					{
						"Повелитель времени",
						"Песочные часы"
					};
					dictionary2[eyy.bl] = new string[]
					{
						"Капкан",
						"Крысоловка"
					};
					int num = 0;
					foreach (KeyValuePair<string, string[]> keyValuePair in dictionary2)
					{
						int num2 = dag.a(dictionary, keyValuePair.Key);
						if (num2 > num)
						{
							num = num2;
							array = keyValuePair.Value;
						}
					}
				}
			}
			if (array == null)
			{
				array = new string[]
				{
					"Убийца",
					"Чёрная вдова"
				};
			}
			string value;
			if (serviceOrThrow.aqu().v().Gender == Gender.Male)
			{
				value = array[0];
			}
			else
			{
				value = array[1];
			}
			serviceOrThrow.aqu().r()["playerArenaTitle"] = value;
		}
	}

	// Token: 0x060031FF RID: 12799 RVA: 0x00132004 File Offset: 0x00130204
	public static int a(Dictionary<string, int> A_0, string A_1)
	{
		int result;
		A_0.TryGetValue(A_1, out result);
		return result;
	}
}
