using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B1C RID: 2844
[eiz("XPBLSCSG")]
[Serializable]
public sealed class alk : cze, ISerializable
{
	// Token: 0x060041B4 RID: 16820 RVA: 0x001955E4 File Offset: 0x001937E4
	private alk(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060041B5 RID: 16821 RVA: 0x001955F0 File Offset: 0x001937F0
	public alk()
	{
	}

	// Token: 0x060041B6 RID: 16822 RVA: 0x001955F8 File Offset: 0x001937F8
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_xpbl_sc_ar_vaultNumber", new int?(0)).Value;
		int[] array = new int[]
		{
			1,
			2,
			3,
			4,
			5
		};
		Random random = new Random(serviceOrThrow.aqu().l());
		random.Next(0, 5);
		for (int i = array.Length; i > 0; i--)
		{
			int num = random.Next(i);
			int num2 = array[i - 1];
			array[i - 1] = array[num];
			array[num] = num2;
		}
		this.a(array, value, A_0, A_1);
	}

	// Token: 0x060041B7 RID: 16823 RVA: 0x001956A0 File Offset: 0x001938A0
	private void a(int[] A_0, int A_1, b0b A_2, b0b A_3)
	{
		string text;
		string text2;
		switch (A_0[A_1 - 1])
		{
		case 1:
			text = "acc19ffb-e909-48d7-9d5b-2df6a3d0fcdc";
			text2 = "edd2a98e-2a88-45be-b9bf-0fb3408b3382";
			break;
		case 2:
			text = "81115bf0-b9fc-41d2-aa6a-62a311425c4d";
			text2 = "b1397a73-4d2a-4e5d-b68f-8b6df2aa6f5f";
			break;
		case 3:
			text = "8fcf901e-1da0-4574-a5db-a5e40ba35d6e";
			text2 = "c172e7dd-13d8-4599-af80-3e7036fc083c";
			break;
		case 4:
			text = "f9524d78-03c2-4635-9831-7c45001e35d7";
			text2 = "aa829e91-4996-4206-a46b-528abe91c6e7";
			break;
		case 5:
			text = "139af789-f76e-440f-a48a-2ab2d1427146";
			text2 = "84bc2a9d-8191-466a-9ed9-df545a61480b";
			break;
		default:
			text = "acc19ffb-e909-48d7-9d5b-2df6a3d0fcdc";
			text2 = "edd2a98e-2a88-45be-b9bf-0fb3408b3382";
			break;
		}
		if (text != null && text2 != null)
		{
			awh awh = new awh();
			awh.b("xpbl_sc_ar");
			awh.b(new Guid(text));
			awh.a(new Guid(text2));
			awh.a(bbo.a);
			awh.ym(A_2, A_3, null);
		}
	}
}
