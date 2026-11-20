using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using TimelapseVertigo.Rules;

// Token: 0x02000B28 RID: 2856
[eiz("XPBLNC")]
[Serializable]
public sealed class e5t : cze, ISerializable
{
	// Token: 0x060041E0 RID: 16864 RVA: 0x001978C8 File Offset: 0x00195AC8
	private e5t(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060041E1 RID: 16865 RVA: 0x001978D4 File Offset: 0x00195AD4
	public e5t()
	{
	}

	// Token: 0x060041E2 RID: 16866 RVA: 0x001978E0 File Offset: 0x00195AE0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		bu6 service = bpo.GetService<bu6>();
		int num = 4;
		Random random = new Random(serviceOrThrow.aqu().l());
		int num2 = random.Next(0, 12);
		int num3 = random.Next(0, 7);
		int num4 = random.Next(7, 12);
		string text = random.Next(1000, 10000).ToString();
		List<string> list = this.a(random, text, service);
		List<string> list2 = new List<string>();
		for (int i = 0; i < 12; i++)
		{
			if (random.Next(0, 2) == 1)
			{
				list2.Add(e5t.b[i]);
			}
			else
			{
				list2.Add(e5t.a[i]);
			}
		}
		List<string> a_ = this.a();
		List<int> list3 = new List<int>();
		if (num2 + num4 >= 12)
		{
			list3.Add(0);
			list3.Add(3);
			list3.Add(6);
		}
		else
		{
			list3.Add(0);
			list3.Add(2);
			list3.Add(4);
		}
		for (int j = list3.Count; j > 1; j--)
		{
			int index = random.Next(j);
			int value = list3[j - 1];
			list3[j - 1] = list3[index];
			list3[index] = value;
		}
		string a_2 = string.Join("", list3.ConvertAll<string>(new Converter<int, string>(e5t.a.a.a)));
		string text2 = string.Concat(new string[]
		{
			"Interval key: ",
			this.b(num2),
			", ",
			this.b(num3),
			", ",
			this.b(num4),
			"."
		});
		serviceOrThrow.aqu().r()["global_xpbl_encryptedText_intervalKey"] = text2;
		this.a(serviceOrThrow, text2, "79 99 116 97 118 101 32 107 101 121 115 58 32 75 101 121 32 49 58 ");
		serviceOrThrow.aqu().r()["global_xpbl_encryptedKeypadCode"] = this.a(text, list2, a_, num2, num3, num4, list3, a_2, "global_xpbl_encryptedKeypadCode_key", null);
		List<string> list4 = this.a(num, random);
		for (int k = 0; k < num; k++)
		{
			string text3 = list4[k];
			if (service != null && service.aq3() > GameDifficulty.Easy)
			{
				List<int> list5 = new List<int>();
				for (int num5 = text3.IndexOf(" ", 0); num5 != -1; num5 = text3.IndexOf(" ", num5 + 1))
				{
					list5.Add(num5);
				}
				text3 = text3.Insert(list5[random.Next(0, list5.Count)], " " + list[k]);
			}
			serviceOrThrow.aqu().r()["global_xpbl_encryptedString" + k.ToString()] = this.a(text3, list2, a_, num2, num3, num4, list3, a_2, "global_xpbl_encryptedString" + k.ToString() + "_key", service);
		}
	}

	// Token: 0x060041E3 RID: 16867 RVA: 0x00197C18 File Offset: 0x00195E18
	private string a(string A_0, List<string> A_1, List<string> A_2, int A_3, int A_4, int A_5, List<int> A_6, string A_7, string A_8, bu6 A_9 = null)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		Dictionary<int, string> dictionary = new Dictionary<int, string>();
		Dictionary<int, int> dictionary2 = new Dictionary<int, int>();
		List<string> list = new List<string>
		{
			A_7
		};
		int count = A_1.Count;
		for (int i = 0; i < count; i++)
		{
			int index = (i + A_3) % count;
			dictionary.Add(i, A_1[index]);
			dictionary2.Add(i, A_6[0] + (i + A_3) / count);
			int index2 = (i + A_3 + A_4) % count;
			dictionary.Add(i + count, A_1[index2]);
			dictionary2.Add(i + count, A_6[1] + (i + A_3 + A_4) / count);
			int index3 = (i + A_3 + A_5) % count;
			dictionary.Add(i + count * 2, A_1[index3]);
			dictionary2.Add(i + count * 2, A_6[2] + (i + A_3 + A_5) / count);
		}
		Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
		Dictionary<string, string> dictionary4 = new Dictionary<string, string>();
		for (int j = 0; j < A_1.Count * 3; j++)
		{
			dictionary3.Add(A_2[j], dictionary[j]);
			dictionary4.Add(A_2[j], dictionary2[j].ToString());
		}
		char[] array = new char[A_0.Length];
		List<string> list2 = new List<string>();
		Random random = new Random(serviceOrThrow.aqu().l());
		int num = 0;
		if (A_9 != null)
		{
			num = (int)A_9.aq3();
		}
		using (StringReader stringReader = new StringReader(A_0.ToLower()))
		{
			stringReader.Read(array, 0, A_0.Length);
			int num2 = 0;
			for (int k = 0; k < array.Length; k++)
			{
				if (char.IsLetter(array[k]) || char.IsNumber(array[k]))
				{
					list2.Add(dictionary3[array[k].ToString()]);
					if (num >= 2)
					{
						if (!char.IsNumber(array[k]) && random.Next(0, 101) < 7)
						{
							list.Add("?");
						}
						else
						{
							list.Add(dictionary4[array[k].ToString()]);
						}
					}
					else
					{
						list.Add(dictionary4[array[k].ToString()]);
					}
				}
				else if (char.IsWhiteSpace(array[k]) && num < 2)
				{
					list2.Add(" ");
				}
				else if (num < 2)
				{
					list2.Add(array[k].ToString());
				}
				if (num >= 2)
				{
					if (num2 == 5)
					{
						list2.Add(" ");
						num2 = 0;
					}
					else
					{
						num2++;
					}
				}
			}
		}
		string result = string.Join("", list2);
		serviceOrThrow.aqu().r()[A_8] = string.Join("", list);
		if (A_8.Contains("global_xpbl_encryptedString"))
		{
			this.a(serviceOrThrow, string.Join(" ", list), "75 101 121 ? 42 ");
		}
		return result;
	}

	// Token: 0x060041E4 RID: 16868 RVA: 0x00197F8C File Offset: 0x0019618C
	private List<string> a(int A_0, Random A_1)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>
		{
			"Hydrothermal Genesis",
			"Ode to the Sun",
			"Of Annihilated Past and Future",
			"Abyssal Horrors",
			"Servant Dance",
			"Lemuria - A Hymn to New Beginnings",
			"Mail from a World Gone by",
			"Cultivating Light in Darkness",
			"Claustrophilic Destiny",
			"Polychromatic Waterscapes",
			"Dreams of Asphyxiation",
			"Crimson Meadow Ballet",
			"The Towering Stars",
			"The Rite of Spring Tide",
			"Prismatic Soot",
			"March of the Protectors",
			"Linda the Handmaiden",
			"Strongman Etude",
			"Electrolin Concerto",
			"Marriage of a Subislander",
			"Genetic Intervention",
			"Omnipresent Pressure",
			"Celestial Nostalgia",
			"Restless Waves Caprice",
			"Citadel of Death",
			"Coral Fantasy",
			"The Barber of Subisle",
			"Rime of the Security Marine",
			"The Rhythm of Extinction"
		};
		for (int i = 0; i <= A_0; i++)
		{
			int index = A_1.Next(0, list2.Count);
			list.Add(list2[index]);
			list2.RemoveAt(index);
		}
		return list;
	}

	// Token: 0x060041E5 RID: 16869 RVA: 0x00198118 File Offset: 0x00196318
	private string b(int A_0)
	{
		string result;
		switch (A_0)
		{
		case 0:
			result = "perfect unison";
			break;
		case 1:
			result = "minor second";
			break;
		case 2:
			result = "major second";
			break;
		case 3:
			result = "minor third";
			break;
		case 4:
			result = "major third";
			break;
		case 5:
			result = "perfect fourth";
			break;
		case 6:
			result = "diminished fifth";
			break;
		case 7:
			result = "perfect fifth";
			break;
		case 8:
			result = "minor sixth";
			break;
		case 9:
			result = "major sixth";
			break;
		case 10:
			result = "minor seventh";
			break;
		case 11:
			result = "major seventh";
			break;
		case 12:
			result = "perfect octave";
			break;
		default:
			result = "unknown interval";
			break;
		}
		return result;
	}

	// Token: 0x060041E6 RID: 16870 RVA: 0x001981FC File Offset: 0x001963FC
	private int b(string A_0)
	{
		if (A_0 != null)
		{
			switch (A_0.Length)
			{
			case 11:
			{
				char c = A_0[1];
				if (c != 'a')
				{
					if (c == 'i')
					{
						if (A_0 == "minor third")
						{
							return 3;
						}
						if (A_0 == "minor sixth")
						{
							return 8;
						}
					}
				}
				else
				{
					if (A_0 == "major third")
					{
						return 4;
					}
					if (A_0 == "major sixth")
					{
						return 9;
					}
				}
				break;
			}
			case 12:
			{
				char c = A_0[1];
				if (c != 'a')
				{
					if (c == 'i')
					{
						if (A_0 == "minor second")
						{
							return 1;
						}
					}
				}
				else if (A_0 == "major second")
				{
					return 2;
				}
				break;
			}
			case 13:
			{
				char c = A_0[1];
				if (c != 'a')
				{
					if (c != 'e')
					{
						if (c == 'i')
						{
							if (A_0 == "minor seventh")
							{
								return 10;
							}
						}
					}
					else if (A_0 == "perfect fifth")
					{
						return 7;
					}
				}
				else if (A_0 == "major seventh")
				{
					return 11;
				}
				break;
			}
			case 14:
			{
				char c = A_0[8];
				if (c != 'f')
				{
					if (c != 'o')
					{
						if (c == 'u')
						{
							if (A_0 == "perfect unison")
							{
								return 0;
							}
						}
					}
					else if (A_0 == "perfect octave")
					{
						return 12;
					}
				}
				else if (A_0 == "perfect fourth")
				{
					return 5;
				}
				break;
			}
			case 16:
				if (A_0 == "diminished fifth")
				{
					return 6;
				}
				break;
			}
		}
		return 0;
	}

	// Token: 0x060041E7 RID: 16871 RVA: 0x0019842C File Offset: 0x0019662C
	private List<string> a(Random A_0, string A_1, bu6 A_2)
	{
		List<string> list = new List<string>();
		for (int i = 0; i < A_1.Length; i++)
		{
			if (A_2 != null && A_2.aq3() >= GameDifficulty.Normal)
			{
				if (A_0.Next(0, 2) == 0)
				{
					string item = this.a(int.Parse(A_1[i].ToString()));
					list.Add(item);
				}
				else
				{
					list.Add(A_1[i].ToString());
				}
			}
			else
			{
				list.Add(A_1[i].ToString());
			}
		}
		return list;
	}

	// Token: 0x060041E8 RID: 16872 RVA: 0x001984CC File Offset: 0x001966CC
	private string a(int A_0)
	{
		string result;
		switch (A_0)
		{
		case 0:
			result = "zero";
			break;
		case 1:
			result = "one";
			break;
		case 2:
			result = "two";
			break;
		case 3:
			result = "three";
			break;
		case 4:
			result = "four";
			break;
		case 5:
			result = "five";
			break;
		case 6:
			result = "six";
			break;
		case 7:
			result = "seven";
			break;
		case 8:
			result = "eight";
			break;
		case 9:
			result = "nine";
			break;
		default:
			result = "";
			break;
		}
		return result;
	}

	// Token: 0x060041E9 RID: 16873 RVA: 0x00198584 File Offset: 0x00196784
	private int a(string A_0)
	{
		if (A_0 != null)
		{
			switch (A_0.Length)
			{
			case 3:
			{
				char c = A_0[0];
				if (c != 'o')
				{
					if (c != 's')
					{
						if (c == 't')
						{
							if (A_0 == "two")
							{
								return 2;
							}
						}
					}
					else if (A_0 == "six")
					{
						return 6;
					}
				}
				else if (A_0 == "one")
				{
					return 1;
				}
				break;
			}
			case 4:
			{
				char c = A_0[2];
				if (c != 'n')
				{
					switch (c)
					{
					case 'r':
						if (A_0 == "zero")
						{
							return 0;
						}
						break;
					case 'u':
						if (A_0 == "four")
						{
							return 4;
						}
						break;
					case 'v':
						if (A_0 == "five")
						{
							return 5;
						}
						break;
					}
				}
				else if (A_0 == "nine")
				{
					return 9;
				}
				break;
			}
			case 5:
			{
				char c = A_0[0];
				if (c != 'e')
				{
					if (c != 's')
					{
						if (c == 't')
						{
							if (A_0 == "three")
							{
								return 3;
							}
						}
					}
					else if (A_0 == "seven")
					{
						return 7;
					}
				}
				else if (A_0 == "eight")
				{
					return 8;
				}
				break;
			}
			}
		}
		return 0;
	}

	// Token: 0x060041EA RID: 16874 RVA: 0x00198750 File Offset: 0x00196950
	private void a(cnk A_0, string A_1, string A_2 = null)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(A_1);
		string text = "";
		foreach (byte b in bytes)
		{
			text = text + b.ToString() + " ";
		}
		string text2 = A_0.aqu().r().GetClassPropertyValue<string>("global_xpbl_encryptedText_ascii") + A_2 + text;
		text2.Replace("42", "?");
		A_0.aqu().r()["global_xpbl_encryptedText_ascii"] = text2;
	}

	// Token: 0x060041EB RID: 16875 RVA: 0x001987E0 File Offset: 0x001969E0
	private List<string> a()
	{
		List<string> list = new List<string>();
		for (char c = 'a'; c <= 'z'; c += '\u0001')
		{
			list.Add(c.ToString());
		}
		for (int i = 0; i <= 9; i++)
		{
			list.Add(i.ToString());
		}
		return list;
	}

	// Token: 0x060041EC RID: 16876 RVA: 0x00198830 File Offset: 0x00196A30
	public string a(string A_0, string A_1, List<string> A_2)
	{
		string text = null;
		int num = 3;
		List<string> list = this.a();
		List<int> list2 = new List<int>();
		for (int i = 0; i < 3; i++)
		{
			list2.Add(int.Parse(A_1[i].ToString()));
		}
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		int num2 = this.b(A_2[0]);
		for (int j = 0; j < 3; j++)
		{
			if (j > 0)
			{
				num2 = this.b(A_2[0]) + this.b(A_2[j]);
			}
			else
			{
				num2 = this.b(A_2[0]);
			}
			for (int k = 0; k < 12; k++)
			{
				dictionary.Add(e5t.b[(k + 12 * j + num2) % 12] + (list2[j] + (k + num2) / 12).ToString(), list[k + 12 * j]);
			}
		}
		for (int l = 0; l < 3; l++)
		{
			if (l > 0)
			{
				num2 = this.b(A_2[0]) + this.b(A_2[l]);
			}
			else
			{
				num2 = this.b(A_2[0]);
			}
			for (int m = 0; m < 12; m++)
			{
				string key = e5t.a[(m + 12 * l + num2) % 12] + (list2[l] + (m + num2) / 12).ToString();
				if (!dictionary.ContainsKey(key))
				{
					dictionary.Add(key, list[m + 12 * l]);
				}
			}
		}
		char[] array = new char[A_0.Length];
		using (StringReader stringReader = new StringReader(A_0))
		{
			stringReader.Read(array, 0, A_0.Length);
			for (int n = 0; n < A_0.Length; n++)
			{
				if (!array[n].Equals('#') && !array[n].Equals('b'))
				{
					if (char.IsLetter(array[n]))
					{
						string key2;
						if (n < A_0.Length - 1 && (array[n + 1].Equals('#') || array[n + 1].Equals('b')))
						{
							key2 = array[n].ToString() + array[n + 1].ToString() + A_1[num].ToString();
						}
						else
						{
							key2 = array[n].ToString() + A_1[num].ToString();
						}
						text += dictionary[key2];
						num++;
					}
					else
					{
						text += array[n].ToString();
					}
				}
			}
		}
		return text;
	}

	// Token: 0x04001C1B RID: 7195
	private new static readonly List<string> a = new List<string>
	{
		"C",
		"C#",
		"D",
		"D#",
		"E",
		"F",
		"F#",
		"G",
		"G#",
		"A",
		"A#",
		"B"
	};

	// Token: 0x04001C1C RID: 7196
	private static readonly List<string> b = new List<string>
	{
		"C",
		"Db",
		"D",
		"Eb",
		"E",
		"F",
		"Gb",
		"G",
		"Ab",
		"A",
		"Bb",
		"B"
	};

	// Token: 0x02000B29 RID: 2857
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060041F0 RID: 16880 RVA: 0x00198CC4 File Offset: 0x00196EC4
		internal string a(int A_0)
		{
			return A_0.ToString();
		}

		// Token: 0x04001C1D RID: 7197
		public static readonly e5t.a a = new e5t.a();

		// Token: 0x04001C1E RID: 7198
		public static Converter<int, string> b;
	}
}
