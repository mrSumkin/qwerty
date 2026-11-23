using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B15 RID: 2837
[eiz("XPBLPIROE")]
[Serializable]
public sealed class e7n : cze, ISerializable
{
	// Token: 0x06004191 RID: 16785 RVA: 0x00192DB4 File Offset: 0x00190FB4
	private e7n(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004192 RID: 16786 RVA: 0x00192DC0 File Offset: 0x00190FC0
	public e7n()
	{
	}

	// Token: 0x06004193 RID: 16787 RVA: 0x00192DCC File Offset: 0x00190FCC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("faction_xpbl_expedition_weaponSupply", new int?(0)).Value;
			int value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("faction_xpbl_expedition_techSupply", new int?(0)).Value;
			int value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("faction_xpbl_expedition_medicineSupply", new int?(0)).Value;
			int value4 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("faction_xpbl_expedition_jetSkiStrength", new int?(0)).Value;
			int value5 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("event_pir_meeting_weaponsOfferLevel", new int?(0)).Value;
			int value6 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("event_pir_meeting_techOfferLevel", new int?(0)).Value;
			int value7 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("event_pir_meeting_medicineOfferLevel", new int?(0)).Value;
			int value8 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("event_pir_meeting_jetsOfferLevel", new int?(0)).Value;
			bool value9 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("event_pir_meeting_offeredMoney", new bool?(false)).Value;
			bool value10 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("event_pir_meeting_offeredUniforms", new bool?(false)).Value;
			bool value11 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("event_pir_meeting_blockadeAgreement", new bool?(false)).Value;
			bool value12 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("event_pir_meeting_savageAgreement", new bool?(false)).Value;
			bool value13 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("event_pir_meeting_lemuriaAgreement", new bool?(false)).Value;
			int num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("event_pir_meeting_extraPointsOffer", new int?(0)).Value;
			int value14 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("faction_xpbl_pirates_totalPiratesKilled", new int?(0)).Value;
			bool value15 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("event_pir_meeting_offerConfirmed", new bool?(false)).Value;
			string text = "";
			int num2 = 0;
			int num3 = 15;
			if (value15)
			{
				bool flag = false;
				if (value8 != 0)
				{
					serviceOrThrow.aqu().r()["faction_xpbl_pir_gotAegisJets"] = true;
					serviceOrThrow.aqu().r()["faction_xpbl_expedition_jetSkiStrength"] = value4 - value8;
					serviceOrThrow.aqu().a(new bw0("xpbl_d5", new cc0(), 1));
					flag = true;
				}
				if (value5 != 0)
				{
					serviceOrThrow.aqu().r()["faction_xpbl_expedition_weaponSupply"] = Math.Max(1, value - value5);
					flag = true;
				}
				if (value6 != 0)
				{
					foreach (string a_ in new List<string>
					{
						"xpbl_g1",
						"xpbl_g2",
						"xpbl_g3",
						"xpbl_f1",
						"xpbl_f2",
						"xpbl_f3",
						"xpbl_e3",
						"xpbl_i5",
						"xpbl_j5"
					})
					{
						serviceOrThrow.aqu().a(new bw0(a_, new avg(), 1));
					}
					serviceOrThrow.aqu().r()["faction_xpbl_pir_haveShields"] = true;
					serviceOrThrow.aqu().r()["faction_xpbl_expedition_techSupply"] = Math.Max(1, value2 - value6);
					flag = true;
				}
				if (value7 != 0)
				{
					serviceOrThrow.aqu().r()["faction_xpbl_expedition_medicineSupply"] = Math.Max(1, value3 - value7);
					flag = true;
				}
				if (value9 && serviceOrThrow.aqu().v() != null)
				{
					serviceOrThrow.aqu().v().Bag.a("currency.sc", 100000);
				}
				serviceOrThrow.aqu().r()["event_pir_meeting_gaveSuppliesToPirates"] = flag;
				return;
			}
			serviceOrThrow.aqu().r()["event_pir_meeting_offerPassed"] = false;
			if (value5 != 0)
			{
				num2 += 4;
				text += "оружие, ";
				num += 3 - value5;
			}
			if (value6 != 0)
			{
				num2 += 4;
				text += "высокотехнологичная экипировка, ";
				num += 3 - value6;
			}
			if (value7 != 0)
			{
				num2 += 4;
				text += "медикаменты, ";
				num += 3 - value7;
			}
			if (value8 != 0)
			{
				num2 += 4;
				text += "гидроциклы, ";
				num += 3 - value8;
			}
			if (value9)
			{
				num2 += 18;
				text += "сто тысяч монет, ";
			}
			if (value10)
			{
				num2 += 2;
				text += "форма Эгиды Инкорпорейтед, ";
			}
			if (value11)
			{
				num2 += 6;
				text += "вырвем ваш гидроцикл из челюстей, ";
			}
			if (value13)
			{
				num2 += 6;
				text += "информация о руинах, ";
			}
			if (value12)
			{
				num2 += 4;
				text += "вы имеете дела с Чешуйчатыми, ";
			}
			serviceOrThrow.aqu().r()["event_pir_meeting_totalSupplyGiven"] = value8 + value5 + value7 + value6;
			text = text.TrimEnd(new char[]
			{
				' ',
				','
			});
			num = ((num - value14 >= num3) ? num3 : (num - value14));
			num2 += num;
			if (num2 != 0)
			{
				serviceOrThrow.aqu().r()["event_pir_meeting_offerMade"] = true;
				serviceOrThrow.aqu().r()["event_pir_meeting_offerLine"] = text;
				if (num2 >= 18)
				{
					serviceOrThrow.aqu().r()["event_pir_meeting_offerHowCloseToPassed"] = "very close";
				}
				else if (num2 >= 12)
				{
					serviceOrThrow.aqu().r()["event_pir_meeting_offerHowCloseToPassed"] = "close";
				}
				else if (num2 >= 6)
				{
					serviceOrThrow.aqu().r()["event_pir_meeting_offerHowCloseToPassed"] = "far";
				}
			}
			if (num2 >= 22)
			{
				serviceOrThrow.aqu().r()["event_pir_meeting_offerPassed"] = true;
			}
		}
	}
}
