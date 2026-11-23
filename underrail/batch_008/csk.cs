using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001C0D RID: 7181
[eiz("D3")]
[Serializable]
public struct csk : ISerializable
{
	// Token: 0x17000290 RID: 656
	// (get) Token: 0x06009D85 RID: 40325 RVA: 0x003DE974 File Offset: 0x003DCB74
	// (set) Token: 0x06009D86 RID: 40326 RVA: 0x003DE97C File Offset: 0x003DCB7C
	public DamageType DamageType
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

	// Token: 0x17000291 RID: 657
	// (get) Token: 0x06009D87 RID: 40327 RVA: 0x003DE988 File Offset: 0x003DCB88
	// (set) Token: 0x06009D88 RID: 40328 RVA: 0x003DE990 File Offset: 0x003DCB90
	public int Amount
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

	// Token: 0x06009D89 RID: 40329 RVA: 0x003DE99C File Offset: 0x003DCB9C
	public static csk a(csk A_0, double A_1)
	{
		return new csk(A_0.DamageType, Convert.ToInt32((double)A_0.Amount * A_1));
	}

	// Token: 0x06009D8A RID: 40330 RVA: 0x003DE9BC File Offset: 0x003DCBBC
	public static bool b(csk A_0, csk A_1)
	{
		return A_0.Equals(A_1);
	}

	// Token: 0x06009D8B RID: 40331 RVA: 0x003DE9D4 File Offset: 0x003DCBD4
	public static bool a(csk A_0, csk A_1)
	{
		return !A_0.Equals(A_1);
	}

	// Token: 0x06009D8C RID: 40332 RVA: 0x003DE9EC File Offset: 0x003DCBEC
	public csk(DamageType A_0, int A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x06009D8D RID: 40333 RVA: 0x003DE9FC File Offset: 0x003DCBFC
	public override string ToString()
	{
		return this.a(false);
	}

	// Token: 0x06009D8E RID: 40334 RVA: 0x003DEA08 File Offset: 0x003DCC08
	public string a(bool A_0)
	{
		return string.Format("{0} {1}", this.b, A_0 ? this.a.ToString().ToLowerInvariant() : this.a.ToString());
	}

	// Token: 0x06009D8F RID: 40335 RVA: 0x003DEA5C File Offset: 0x003DCC5C
	public override bool Equals(object obj)
	{
		if (obj is csk)
		{
			csk csk = (csk)obj;
			return this.a == csk.a && this.b == csk.b;
		}
		return false;
	}

	// Token: 0x06009D90 RID: 40336 RVA: 0x003DEAA0 File Offset: 0x003DCCA0
	public override int GetHashCode()
	{
		return this.a.GetHashCode() + this.b.GetHashCode();
	}

	// Token: 0x06009D91 RID: 40337 RVA: 0x003DEAC4 File Offset: 0x003DCCC4
	private csk(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() >= 3)
		{
			this.b = A_0.GetInt32("A");
			this.a = (DamageType)A_0.GetValue("T", typeof(DamageType));
			return;
		}
		this.b = A_0.GetInt32("_Amount");
		this.a = (DamageType)A_0.GetValue("_DamageType", typeof(DamageType));
	}

	// Token: 0x06009D92 RID: 40338 RVA: 0x003DEB40 File Offset: 0x003DCD40
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("A", this.b);
		info.AddValue("T", this.a);
	}

	// Token: 0x04003CEF RID: 15599
	private DamageType a;

	// Token: 0x04003CF0 RID: 15600
	private int b;
}
