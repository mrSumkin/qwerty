using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001128 RID: 4392
[eiz("UHEJ")]
[Serializable]
public sealed class e5u : cze, ISerializable
{
	// Token: 0x06005DE9 RID: 24041 RVA: 0x0027D2D0 File Offset: 0x0027B4D0
	private e5u(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetBoolean("UHEJ:I");
			this.b = A_0.GetString("UHEJ:A");
			this.c = (Guid?)A_0.GetValue("UHEJ:I1", typeof(Guid?));
			return;
		}
		if (base.GetType() == typeof(e5u))
		{
			this.a = A_0.GetBoolean("_Instant");
			this.b = A_0.GetString("_Area");
			this.c = (Guid?)A_0.GetValue("_Id", typeof(Guid?));
			return;
		}
		this.a = A_0.GetBoolean("UncoverHiddenEntityJob+_Instant");
		this.b = A_0.GetString("UncoverHiddenEntityJob+_Area");
		this.c = (Guid?)A_0.GetValue("UncoverHiddenEntityJob+_Id", typeof(Guid?));
	}

	// Token: 0x06005DEA RID: 24042 RVA: 0x0027D3D8 File Offset: 0x0027B5D8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("UHEJ:I", this.a);
		info.AddValue("UHEJ:A", this.b);
		info.AddValue("UHEJ:I1", this.c);
	}

	// Token: 0x06005DEB RID: 24043 RVA: 0x0027D428 File Offset: 0x0027B628
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06005DEC RID: 24044 RVA: 0x0027D430 File Offset: 0x0027B630
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005DED RID: 24045 RVA: 0x0027D43C File Offset: 0x0027B63C
	public Guid? c()
	{
		return this.c;
	}

	// Token: 0x06005DEE RID: 24046 RVA: 0x0027D444 File Offset: 0x0027B644
	public void a(Guid? A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005DEF RID: 24047 RVA: 0x0027D450 File Offset: 0x0027B650
	public string b()
	{
		return this.b;
	}

	// Token: 0x06005DF0 RID: 24048 RVA: 0x0027D458 File Offset: 0x0027B658
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005DF1 RID: 24049 RVA: 0x0027D464 File Offset: 0x0027B664
	public e5u()
	{
	}

	// Token: 0x06005DF2 RID: 24050 RVA: 0x0027D474 File Offset: 0x0027B674
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		b0b b0b;
		if (this.c == null)
		{
			b0b = A_1;
		}
		else
		{
			aud aud = cze.a(this.b, A_0, A_1, A_2);
			if (aud == null)
			{
				return;
			}
			b0b = aud.a(this.c.Value);
		}
		if (b0b != null)
		{
			bool a_ = false;
			object obj;
			if (A_2 != null && A_2.TryGetValue("ignoreConditions", out obj) && obj is bool)
			{
				bool flag = (bool)obj;
				a_ = flag;
			}
			b4h aspect = b0b.GetAspect<b4h>();
			if (aspect != null)
			{
				aspect.a(A_0, this.a, a_);
			}
		}
	}

	// Token: 0x0400255E RID: 9566
	private new bool a = true;

	// Token: 0x0400255F RID: 9567
	private string b;

	// Token: 0x04002560 RID: 9568
	private Guid? c;
}
