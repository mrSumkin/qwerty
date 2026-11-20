using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001034 RID: 4148
[eiz("ASJ")]
[Serializable]
public sealed class dqs : cze
{
	// Token: 0x060055A4 RID: 21924 RVA: 0x0025C1C4 File Offset: 0x0025A3C4
	private dqs(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid?)A_0.GetValue("ASJ:I", typeof(Guid?));
		this.b = A_0.GetString("ASJ:A");
	}

	// Token: 0x060055A5 RID: 21925 RVA: 0x0025C200 File Offset: 0x0025A400
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ASJ:I", this.a);
		info.AddValue("ASJ:A", this.b);
	}

	// Token: 0x060055A6 RID: 21926 RVA: 0x0025C234 File Offset: 0x0025A434
	public string a()
	{
		return this.b;
	}

	// Token: 0x060055A7 RID: 21927 RVA: 0x0025C23C File Offset: 0x0025A43C
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060055A8 RID: 21928 RVA: 0x0025C248 File Offset: 0x0025A448
	public Guid? b()
	{
		return this.a;
	}

	// Token: 0x060055A9 RID: 21929 RVA: 0x0025C250 File Offset: 0x0025A450
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060055AA RID: 21930 RVA: 0x0025C25C File Offset: 0x0025A45C
	public dqs()
	{
	}

	// Token: 0x060055AB RID: 21931 RVA: 0x0025C264 File Offset: 0x0025A464
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		b0b b0b = A_0 ?? A_1;
		c5x c5x = null;
		if (this.a != null && b0b != null)
		{
			aud aud = null;
			if (this.b != null)
			{
				aud = b0b.Zone.n(this.b);
			}
			else if (A_1 != null)
			{
				aud = b0b.Area;
			}
			if (aud != null)
			{
				c5x = (new ar7(this.a.Value, aud).ao() as c5x);
			}
		}
		else
		{
			c5x = (A_1 as c5x);
		}
		if (c5x != null)
		{
			dg2 aspect = c5x.GetAspect<dg2>();
			if (aspect != null)
			{
				aspect.b(0);
			}
		}
	}

	// Token: 0x040022D6 RID: 8918
	private new Guid? a;

	// Token: 0x040022D7 RID: 8919
	private string b;
}
