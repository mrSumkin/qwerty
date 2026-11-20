using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001C0F RID: 7183
[eiz("DR2")]
[Serializable]
public struct du2 : ISerializable
{
	// Token: 0x06009DA4 RID: 40356 RVA: 0x003DEE8C File Offset: 0x003DD08C
	public DamageType b()
	{
		return this.a;
	}

	// Token: 0x06009DA5 RID: 40357 RVA: 0x003DEE94 File Offset: 0x003DD094
	public void a(DamageType A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06009DA6 RID: 40358 RVA: 0x003DEEA0 File Offset: 0x003DD0A0
	public int a()
	{
		return this.b;
	}

	// Token: 0x06009DA7 RID: 40359 RVA: 0x003DEEA8 File Offset: 0x003DD0A8
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06009DA8 RID: 40360 RVA: 0x003DEEB4 File Offset: 0x003DD0B4
	public double c()
	{
		return this.c;
	}

	// Token: 0x06009DA9 RID: 40361 RVA: 0x003DEEBC File Offset: 0x003DD0BC
	public void a(double A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06009DAA RID: 40362 RVA: 0x003DEEC8 File Offset: 0x003DD0C8
	public static bool b(du2 A_0, du2 A_1)
	{
		return A_0.Equals(A_1);
	}

	// Token: 0x06009DAB RID: 40363 RVA: 0x003DEEE0 File Offset: 0x003DD0E0
	public static bool a(du2 A_0, du2 A_1)
	{
		return !A_0.Equals(A_1);
	}

	// Token: 0x06009DAC RID: 40364 RVA: 0x003DEEF8 File Offset: 0x003DD0F8
	public du2(DamageType A_0, int A_1, double A_2)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
	}

	// Token: 0x06009DAD RID: 40365 RVA: 0x003DEF10 File Offset: 0x003DD110
	public void a(du2 A_0)
	{
		this.b += A_0.b;
		this.c += A_0.c;
	}

	// Token: 0x06009DAE RID: 40366 RVA: 0x003DEF3C File Offset: 0x003DD13C
	public override bool Equals(object obj)
	{
		if (obj is du2)
		{
			du2 du = (du2)obj;
			return this.a == du.a && this.b == du.b && this.c == du.c;
		}
		return false;
	}

	// Token: 0x06009DAF RID: 40367 RVA: 0x003DEF90 File Offset: 0x003DD190
	public override int GetHashCode()
	{
		return this.a.GetHashCode() + this.b.GetHashCode() + this.c.GetHashCode();
	}

	// Token: 0x06009DB0 RID: 40368 RVA: 0x003DEFC0 File Offset: 0x003DD1C0
	public override string ToString()
	{
		string text = "";
		if (this.c() != 0.0)
		{
			text = string.Format("{0}%", Convert.ToInt32(this.c() * 100.0));
		}
		if (this.a() != 0)
		{
			if (text != "")
			{
				text += " / ";
			}
			text += this.b.ToString();
		}
		if (text == "")
		{
			text = "Нет";
		}
		return text;
	}

	// Token: 0x06009DB1 RID: 40369 RVA: 0x003DF05C File Offset: 0x003DD25C
	private du2(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() < 3)
		{
			this.b = A_0.GetInt32("_Value");
			this.a = (DamageType)A_0.GetValue("_DamageType", typeof(DamageType));
			this.c = 0.0;
			return;
		}
		this.b = A_0.GetInt32("V");
		this.a = (DamageType)A_0.GetValue("T", typeof(DamageType));
		if (ell.a() >= 88)
		{
			this.c = A_0.GetDouble("R");
			return;
		}
		this.c = 0.0;
	}

	// Token: 0x06009DB2 RID: 40370 RVA: 0x003DF114 File Offset: 0x003DD314
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("V", this.b);
		info.AddValue("T", this.a);
		info.AddValue("R", this.c);
	}

	// Token: 0x04003CF4 RID: 15604
	private DamageType a;

	// Token: 0x04003CF5 RID: 15605
	private int b;

	// Token: 0x04003CF6 RID: 15606
	private double c;
}
