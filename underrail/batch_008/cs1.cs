using System;

// Token: 0x02000662 RID: 1634
public static class cs1
{
	// Token: 0x0600297F RID: 10623 RVA: 0x000EC344 File Offset: 0x000EA544
	public static float a(bq8 A_0, dkg A_1)
	{
		if (A_0 != null)
		{
			string str = "chRep_";
			int num = (int)A_1;
			float? primitivePropertyValue = A_0.GetPrimitivePropertyValue<float>(str + num.ToString() + "_ir", new float?(0f));
			string str2 = "chRep_";
			num = (int)A_1;
			float? primitivePropertyValue2 = A_0.GetPrimitivePropertyValue<float>(str2 + num.ToString(), new float?(0f));
			return primitivePropertyValue.Value + primitivePropertyValue2.Value;
		}
		return 0f;
	}

	// Token: 0x06002980 RID: 10624 RVA: 0x000EC3BC File Offset: 0x000EA5BC
	public static void a(bq8 A_0, dkg A_1, float A_2, bool A_3, float? A_4, float? A_5)
	{
		int num;
		string name;
		if (A_3)
		{
			string str = "chRep_";
			num = (int)A_1;
			name = str + num.ToString() + "_ir";
		}
		else
		{
			string str2 = "chRep_";
			num = (int)A_1;
			name = str2 + num.ToString();
		}
		string str3 = "chRep_";
		num = (int)A_1;
		float value = A_0.GetPrimitivePropertyValue<float>(str3 + num.ToString() + "_ir", new float?(0f)).Value;
		float num2 = d05.b((A_5 != null) ? A_5.Value : float.MinValue, value + A_2, (A_4 != null) ? A_4.Value : float.MaxValue);
		A_0.SetPropertyValue(name, num2);
	}

	// Token: 0x06002981 RID: 10625 RVA: 0x000EC488 File Offset: 0x000EA688
	public static float a(bq8 A_0)
	{
		if (A_0 != null)
		{
			return A_0.GetPrimitivePropertyValue<float>(bp5.e, new float?(0f)).Value;
		}
		return 0f;
	}

	// Token: 0x06002982 RID: 10626 RVA: 0x000EC4C0 File Offset: 0x000EA6C0
	public static void a(bq8 A_0, float A_1, float? A_2, float? A_3)
	{
		float value = A_0.GetPrimitivePropertyValue<float>(bp5.e, new float?(0f)).Value;
		float num = d05.b((A_3 != null) ? A_3.Value : float.MinValue, value + A_1, (A_2 != null) ? A_2.Value : float.MaxValue);
		A_0.SetPropertyValue(bp5.e, num);
	}

	// Token: 0x040016A2 RID: 5794
	private const string a = "chRep_";

	// Token: 0x040016A3 RID: 5795
	private const string b = "_ir";
}
