using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200102C RID: 4140
[eiz("CCFJ")]
[Serializable]
public sealed class dve : cze, ISerializable
{
	// Token: 0x06005570 RID: 21872 RVA: 0x0025B7FC File Offset: 0x002599FC
	private dve(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (bvl)A_0.GetValue("CCFJ:T", typeof(bvl));
		this.a = (A_0.GetValue("CCFJ:CT", typeof(Guid?)) as Guid?);
		this.c = A_0.GetString("CCFJ:F");
		this.d = A_0.GetBoolean("CCFJ:P");
	}

	// Token: 0x06005571 RID: 21873 RVA: 0x0025B880 File Offset: 0x00259A80
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CCFJ:T", this.b);
		info.AddValue("CCFJ:CT", this.a);
		info.AddValue("CCFJ:F", this.c);
		info.AddValue("CCFJ:P", this.d);
	}

	// Token: 0x06005572 RID: 21874 RVA: 0x0025B8E4 File Offset: 0x00259AE4
	public bvl c()
	{
		return this.b;
	}

	// Token: 0x06005573 RID: 21875 RVA: 0x0025B8EC File Offset: 0x00259AEC
	public void a(bvl A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005574 RID: 21876 RVA: 0x0025B8F8 File Offset: 0x00259AF8
	public Guid? d()
	{
		return this.a;
	}

	// Token: 0x06005575 RID: 21877 RVA: 0x0025B900 File Offset: 0x00259B00
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005576 RID: 21878 RVA: 0x0025B90C File Offset: 0x00259B0C
	public string b()
	{
		return this.c;
	}

	// Token: 0x06005577 RID: 21879 RVA: 0x0025B914 File Offset: 0x00259B14
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005578 RID: 21880 RVA: 0x0025B920 File Offset: 0x00259B20
	public bool a()
	{
		return this.d;
	}

	// Token: 0x06005579 RID: 21881 RVA: 0x0025B928 File Offset: 0x00259B28
	public void a(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600557A RID: 21882 RVA: 0x0025B934 File Offset: 0x00259B34
	public dve()
	{
	}

	// Token: 0x0600557B RID: 21883 RVA: 0x0025B948 File Offset: 0x00259B48
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (this.a != null)
		{
			aud aud = null;
			if (A_0 != null)
			{
				aud = A_0.Area;
			}
			if (aud == null && A_1 != null)
			{
				aud = A_1.Area;
			}
			if (aud != null)
			{
				c5x = (aud.a(this.a.Value) as c5x);
			}
		}
		else
		{
			switch (this.b)
			{
			case bvl.b:
				c5x = (A_0 as c5x);
				break;
			case bvl.c:
				c5x = (A_1 as c5x);
				break;
			case bvl.d:
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
				{
					c5x = (serviceOrThrow.aqu().v().b() as c5x);
				}
				break;
			}
			}
		}
		if (c5x != null && c5x.h.b != null)
		{
			c5x.h.b.aa().FactionId = this.c;
			if (this.d)
			{
				c5x.h.b.aa().PersonalAttitudes.Clear();
			}
		}
	}

	// Token: 0x040022C8 RID: 8904
	private new Guid? a;

	// Token: 0x040022C9 RID: 8905
	private bvl b = bvl.c;

	// Token: 0x040022CA RID: 8906
	private string c;

	// Token: 0x040022CB RID: 8907
	private bool d;
}
