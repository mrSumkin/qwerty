using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020013D8 RID: 5080
[eiz("SEA9")]
[Serializable]
public sealed class au0 : dvv, ISerializable
{
	// Token: 0x0600725A RID: 29274 RVA: 0x00300EF0 File Offset: 0x002FF0F0
	private au0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.f = (Vector3)A_0.GetValue("SEA9:L", typeof(Vector3));
		this.g = (A_0.GetValue("SEA9:A", typeof(e6z)) as e6z);
		this.a = A_0.GetString("SEA9:EM");
		this.b = A_0.GetInt32("SEA9:MC");
		this.c = A_0.GetDouble("SEA9:MD");
		this.d = (int?)A_0.GetValue("SEA9:OPS", typeof(int?));
		this.e = (float?)A_0.GetValue("SEA9:OA", typeof(float?));
		if (ell.a() >= 330)
		{
			this.h = (float?)A_0.GetValue("SEA9:P", typeof(float?));
		}
	}

	// Token: 0x0600725B RID: 29275 RVA: 0x00300FE8 File Offset: 0x002FF1E8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SEA9:L", this.f);
		info.AddValue("SEA9:A", this.g);
		info.AddValue("SEA9:EM", this.a);
		info.AddValue("SEA9:MC", this.b);
		info.AddValue("SEA9:MD", this.c);
		info.AddValue("SEA9:OPS", this.d);
		info.AddValue("SEA9:OA", this.e);
		info.AddValue("SEA9:P", this.h);
	}

	// Token: 0x0600725C RID: 29276 RVA: 0x0030109C File Offset: 0x002FF29C
	public int? b()
	{
		return this.d;
	}

	// Token: 0x0600725D RID: 29277 RVA: 0x003010A4 File Offset: 0x002FF2A4
	public void a(int? A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600725E RID: 29278 RVA: 0x003010B0 File Offset: 0x002FF2B0
	public float? a()
	{
		return this.e;
	}

	// Token: 0x0600725F RID: 29279 RVA: 0x003010B8 File Offset: 0x002FF2B8
	public void a(float? A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06007260 RID: 29280 RVA: 0x003010C4 File Offset: 0x002FF2C4
	public au0(aud A_0, Vector3 A_1, string A_2, int A_3, double A_4, float? A_5 = null, int? A_6 = null, float? A_7 = null)
	{
		this.f = A_1;
		this.g = new e6z(A_0);
		this.a = A_2;
		this.b = A_3;
		this.c = A_4;
		this.e = A_5;
		this.d = A_6;
		this.h = A_7;
	}

	// Token: 0x06007261 RID: 29281 RVA: 0x0030111C File Offset: 0x002FF31C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.g == null || this.g.ao() == null)
		{
			return dc4.e;
		}
		boj.a(this.g.ao(), this.f, null, this.a, this.b, this.c, this.d, this.e, this.h, null);
		return dc4.c;
	}

	// Token: 0x04002EAB RID: 11947
	private new string a;

	// Token: 0x04002EAC RID: 11948
	private int b;

	// Token: 0x04002EAD RID: 11949
	private double c;

	// Token: 0x04002EAE RID: 11950
	private int? d;

	// Token: 0x04002EAF RID: 11951
	private float? e;

	// Token: 0x04002EB0 RID: 11952
	private Vector3 f;

	// Token: 0x04002EB1 RID: 11953
	private e6z g;

	// Token: 0x04002EB2 RID: 11954
	private float? h;
}
