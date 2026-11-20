using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000AD9 RID: 2777
[eiz("XPBLFGFNJ")]
[Serializable]
public sealed class du6 : cze, ISerializable
{
	// Token: 0x060040BD RID: 16573 RVA: 0x0018AAEC File Offset: 0x00188CEC
	private du6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060040BE RID: 16574 RVA: 0x0018AAF8 File Offset: 0x00188CF8
	public du6()
	{
	}

	// Token: 0x060040BF RID: 16575 RVA: 0x0018AB04 File Offset: 0x00188D04
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().r().GetClassPropertyValue<string>("npc_xpbl_ferryman_realName") == null)
		{
			string[] array = new string[]
			{
				"Джеймс",
				"Джек",
				"Роберт",
				"Макс",
				"Джордж",
				"Джон",
				"Томас",
				"Ричард",
				"Уильям",
				"Кристофер",
				"Стивен",
				"Даниель",
				"Кеннет",
				"Джеффри",
				"Скотт"
			};
			string[] array2 = new string[]
			{
				"Кларк",
				"Уокер",
				"Картер",
				"Дэвис",
				"Харрис",
				"Мур",
				"Льюис",
				"Типтон",
				"Даунинг",
				"Черчилль",
				"Мёрфи",
				"Вашингтон",
				"Пауэлл",
				"Колеман",
				"Фостер"
			};
			Random random = new Random(serviceOrThrow.aqu().l());
			string text = array[random.Next(0, array.Length)];
			string text2 = array2[random.Next(0, array2.Length)];
			serviceOrThrow.aqu().r()["npc_xpbl_ferryman_realName"] = string.Concat(new string[]
			{
				text,
				". ",
				text,
				" ",
				text2,
				"."
			});
		}
	}
}
