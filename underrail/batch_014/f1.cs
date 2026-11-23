using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200195B RID: 6491
[eiz("SFY")]
[Serializable]
public struct f1 : ISerializable
{
	// Token: 0x06008AAA RID: 35498 RVA: 0x0038D780 File Offset: 0x0038B980
	private f1(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (ImpactSpeed)A_0.GetValue("SFY:I", typeof(ImpactSpeed));
		this.b = A_0.GetInt32("SFY:B");
		this.c = A_0.GetDouble("SFY:N");
	}

	// Token: 0x06008AAB RID: 35499 RVA: 0x0038D7D0 File Offset: 0x0038B9D0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("SFY:I", this.a);
		info.AddValue("SFY:B", this.b);
		info.AddValue("SFY:N", this.c);
	}

	// Token: 0x06008AAC RID: 35500 RVA: 0x0038D80C File Offset: 0x0038BA0C
	public ImpactSpeed b()
	{
		return this.a;
	}

	// Token: 0x06008AAD RID: 35501 RVA: 0x0038D814 File Offset: 0x0038BA14
	public void a(ImpactSpeed A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008AAE RID: 35502 RVA: 0x0038D820 File Offset: 0x0038BA20
	public int a()
	{
		return this.b;
	}

	// Token: 0x06008AAF RID: 35503 RVA: 0x0038D828 File Offset: 0x0038BA28
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06008AB0 RID: 35504 RVA: 0x0038D834 File Offset: 0x0038BA34
	public double c()
	{
		return this.c;
	}

	// Token: 0x06008AB1 RID: 35505 RVA: 0x0038D83C File Offset: 0x0038BA3C
	public void a(double A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06008AB2 RID: 35506 RVA: 0x0038D848 File Offset: 0x0038BA48
	public static bool b(f1 A_0, f1 A_1)
	{
		return A_0.Equals(A_1);
	}

	// Token: 0x06008AB3 RID: 35507 RVA: 0x0038D860 File Offset: 0x0038BA60
	public static bool a(f1 A_0, f1 A_1)
	{
		return !A_0.Equals(A_1);
	}

	// Token: 0x06008AB4 RID: 35508 RVA: 0x0038D878 File Offset: 0x0038BA78
	public f1(ImpactSpeed A_0, int A_1, double A_2)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
	}

	// Token: 0x06008AB5 RID: 35509 RVA: 0x0038D890 File Offset: 0x0038BA90
	public override bool Equals(object obj)
	{
		if (obj is f1)
		{
			f1 f = (f1)obj;
			return this.a == f.a && this.b == f.b && this.c == f.c;
		}
		return false;
	}

	// Token: 0x06008AB6 RID: 35510 RVA: 0x0038D8E4 File Offset: 0x0038BAE4
	public override int GetHashCode()
	{
		return this.a.GetHashCode() + this.b.GetHashCode() + this.c.GetHashCode();
	}

	// Token: 0x06008AB7 RID: 35511 RVA: 0x0038D910 File Offset: 0x0038BB10
	public override string ToString()
	{
		return string.Format("{0} {1}+{2}", this.a.ToString(), this.b, this.c);
	}

	// Token: 0x04003718 RID: 14104
	private ImpactSpeed a;

	// Token: 0x04003719 RID: 14105
	private int b;

	// Token: 0x0400371A RID: 14106
	private double c;
}
