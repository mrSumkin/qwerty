using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000AD1 RID: 2769
[eiz("XPBLNCIC")]
[Serializable]
public sealed class ad : cze, ISerializable
{
	// Token: 0x06004098 RID: 16536 RVA: 0x00189540 File Offset: 0x00187740
	private ad(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004099 RID: 16537 RVA: 0x0018954C File Offset: 0x0018774C
	public ad()
	{
	}

	// Token: 0x0600409A RID: 16538 RVA: 0x00189558 File Offset: 0x00187758
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		if (A_0 != null)
		{
			aud = A_0.Area;
		}
		else if (A_1 != null)
		{
			aud = A_1.Area;
		}
		if (aud != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("interfacing_xpbl_ncd_keepCoordinatesAdded", new bool?(false)).Value;
				bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("interfacing_xpbl_ncd_horticultureCoordinatesAdded", new bool?(false)).Value;
				bool value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("interfacing_xpbl_ncd_compoundCoordinatesAdded", new bool?(false)).Value;
				bool value4 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("interfacing_xpbl_ncd_abyssCourseCoordinatesAdded", new bool?(false)).Value;
				bool value5 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_investigateNexus_started", new bool?(false)).Value;
				bool value6 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_investigateMedical_started", new bool?(false)).Value;
				bool value7 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_submarine_started", new bool?(false)).Value;
				SortedSet<string> sortedSet = new SortedSet<string>();
				string text = "Западный складской комплекс - B7";
				string text2 = "Зеленоватый карьер - L4";
				string text3 = "Хранилище Арч-Айленда - E6";
				string text4 = "Единый Центр Безопасности - F12";
				string text5 = "Центр здоровья лемуриан - I1";
				string text6 = "Агроцентр Багровый луг - H7";
				string text7 = "Технологии Нексуса - K7";
				string text8 = "Цитадель жизни - G1";
				string text9 = "Исследовательский центр Бурлящих берегов - L12";
				string text10 = "Подъёмники станции Зеро - L2";
				string str = " (CC: 020 476 118 263 2115)";
				string text11 = "Лемурийский производственный комплекс - K3";
				sortedSet.Add("Лагерь экспедиции на Чёрном море - D5, D6, E5, E6");
				sortedSet.Add("Западный складской комплекс - B7");
				string text12;
				if (value4)
				{
					text12 = text10 + str;
				}
				else
				{
					text12 = text10;
				}
				if (value)
				{
					sortedSet.Add(text);
					sortedSet.Add(text3);
					sortedSet.Add(text6);
					sortedSet.Add(text7);
					sortedSet.Add(text9);
					sortedSet.Add(text2);
				}
				if (value2)
				{
					sortedSet.Add(text2);
					sortedSet.Add(text6);
					sortedSet.Add(text5);
					sortedSet.Add(text8);
					sortedSet.Add(text3);
					sortedSet.Add(text4);
					sortedSet.Add(text11);
					sortedSet.Add(text7);
					sortedSet.Add(text9);
				}
				if (value3)
				{
					sortedSet.Add(text12);
					sortedSet.Add(text3);
					sortedSet.Add(text4);
					sortedSet.Add(text11);
					sortedSet.Add(text7);
					sortedSet.Add(text9);
				}
				if (value5)
				{
					sortedSet.Add(text6);
					sortedSet.Add(text7);
				}
				if (value6)
				{
					sortedSet.Add(text5);
					sortedSet.Add(text4);
				}
				if (value7)
				{
					sortedSet.Add(text9);
				}
				string value8 = string.Join(Environment.NewLine, sortedSet);
				serviceOrThrow.aqu().r()["interfacing_xpbl_navcom_acquiredCoordinates"] = value8;
			}
		}
	}
}
