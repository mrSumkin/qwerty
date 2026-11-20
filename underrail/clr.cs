using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200103C RID: 4156
[eiz("CASVDJ")]
[Serializable]
public sealed class clr : cze
{
	// Token: 0x060055E9 RID: 21993 RVA: 0x0025D464 File Offset: 0x0025B664
	private clr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid?)A_0.GetValue("CASVDJ:I", typeof(Guid?));
		this.b = A_0.GetString("CASVDJ:A");
		this.c = (bbo)A_0.GetValue("CASVDJ:O", typeof(bbo));
	}

	// Token: 0x060055EA RID: 21994 RVA: 0x0025D4CC File Offset: 0x0025B6CC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CASVDJ:I", this.a);
		info.AddValue("CASVDJ:A", this.b);
		info.AddValue("CASVDJ:O", this.c);
	}

	// Token: 0x170001B6 RID: 438
	// (get) Token: 0x060055EB RID: 21995 RVA: 0x0025D520 File Offset: 0x0025B720
	// (set) Token: 0x060055EC RID: 21996 RVA: 0x0025D528 File Offset: 0x0025B728
	public string OverrideTargetArea
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

	// Token: 0x170001B7 RID: 439
	// (get) Token: 0x060055ED RID: 21997 RVA: 0x0025D534 File Offset: 0x0025B734
	// (set) Token: 0x060055EE RID: 21998 RVA: 0x0025D53C File Offset: 0x0025B73C
	public Guid? OverrideTargetId
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

	// Token: 0x170001B8 RID: 440
	// (get) Token: 0x060055EF RID: 21999 RVA: 0x0025D548 File Offset: 0x0025B748
	// (set) Token: 0x060055F0 RID: 22000 RVA: 0x0025D550 File Offset: 0x0025B750
	public bbo Operation
	{
		get
		{
			return this.c;
		}
		set
		{
			this.c = value;
		}
	}

	// Token: 0x060055F1 RID: 22001 RVA: 0x0025D55C File Offset: 0x0025B75C
	public clr()
	{
	}

	// Token: 0x060055F2 RID: 22002 RVA: 0x0025D568 File Offset: 0x0025B768
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (this.a != null)
		{
			aud aud = cze.a(this.b, A_0, A_1, A_2);
			if (aud != null)
			{
				c5x = (aud.a(this.a.Value) as c5x);
			}
		}
		else
		{
			c5x = (A_1 as c5x);
		}
		if (c5x != null)
		{
			aw aspect = c5x.GetAspect<aw>();
			if (aspect != null)
			{
				if (this.c == bbo.a)
				{
					aspect.e();
					return;
				}
				if (this.c == bbo.b)
				{
					aspect.b(false);
					return;
				}
				aspect.c(false);
			}
		}
	}

	// Token: 0x040022E9 RID: 8937
	private new Guid? a;

	// Token: 0x040022EA RID: 8938
	private string b;

	// Token: 0x040022EB RID: 8939
	private bbo c;
}
