using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001C10 RID: 7184
[eiz("S7")]
[Serializable]
public struct z3 : ISerializable
{
	// Token: 0x17000295 RID: 661
	// (get) Token: 0x06009DB3 RID: 40371 RVA: 0x003DF150 File Offset: 0x003DD350
	// (set) Token: 0x06009DB4 RID: 40372 RVA: 0x003DF158 File Offset: 0x003DD358
	public ImpactSpeed ImpactSpeed
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x17000296 RID: 662
	// (get) Token: 0x06009DB5 RID: 40373 RVA: 0x003DF164 File Offset: 0x003DD364
	// (set) Token: 0x06009DB6 RID: 40374 RVA: 0x003DF16C File Offset: 0x003DD36C
	public int Value
	{
		get
		{
			return this.b;
		}
		set
		{
			this.b = value;
		}
	}

	// Token: 0x06009DB7 RID: 40375 RVA: 0x003DF178 File Offset: 0x003DD378
	public static bool b(z3 A_0, z3 A_1)
	{
		return A_0.Equals(A_1);
	}

	// Token: 0x06009DB8 RID: 40376 RVA: 0x003DF190 File Offset: 0x003DD390
	public static bool a(z3 A_0, z3 A_1)
	{
		return !A_0.Equals(A_1);
	}

	// Token: 0x06009DB9 RID: 40377 RVA: 0x003DF1A8 File Offset: 0x003DD3A8
	public z3(ImpactSpeed A_0, int A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x06009DBA RID: 40378 RVA: 0x003DF1B8 File Offset: 0x003DD3B8
	public override string ToString()
	{
		return string.Format("{0} {1}", this.a, this.b);
	}

	// Token: 0x06009DBB RID: 40379 RVA: 0x003DF1DC File Offset: 0x003DD3DC
	public override bool Equals(object obj)
	{
		if (obj is z3)
		{
			z3 z = (z3)obj;
			return this.a == z.a && this.b == z.b;
		}
		return false;
	}

	// Token: 0x06009DBC RID: 40380 RVA: 0x003DF220 File Offset: 0x003DD420
	public override int GetHashCode()
	{
		return this.a.GetHashCode() + this.b.GetHashCode();
	}

	// Token: 0x06009DBD RID: 40381 RVA: 0x003DF244 File Offset: 0x003DD444
	private z3(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() >= 3)
		{
			this.b = A_0.GetInt32("V");
			this.a = (ImpactSpeed)A_0.GetValue("I", typeof(ImpactSpeed));
			return;
		}
		this.b = A_0.GetInt32("_Value");
		this.a = (ImpactSpeed)A_0.GetValue("_ImpactSpeed", typeof(ImpactSpeed));
	}

	// Token: 0x06009DBE RID: 40382 RVA: 0x003DF2C0 File Offset: 0x003DD4C0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("V", this.b);
		info.AddValue("I", this.a);
	}

	// Token: 0x04003CF7 RID: 15607
	private ImpactSpeed a;

	// Token: 0x04003CF8 RID: 15608
	private int b;
}
