using System;
using System.Runtime.Serialization;

// Token: 0x02001214 RID: 4628
[eiz("LNT")]
[Serializable]
public sealed class d9s : cca, ISerializable
{
	// Token: 0x06006394 RID: 25492 RVA: 0x002AEC18 File Offset: 0x002ACE18
	private d9s(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("LNT:T");
			this.b = (Guid?)A_0.GetValue("LNT:S", typeof(Guid?));
			this.c = A_0.GetBoolean("LNT:IT");
			return;
		}
		if (base.GetType() == typeof(d9s))
		{
			this.a = A_0.GetString("_Text");
			this.b = (Guid?)A_0.GetValue("_Speaker", typeof(Guid?));
			try
			{
				this.c = A_0.GetBoolean("_InterruptTalking");
				return;
			}
			catch
			{
				return;
			}
		}
		this.a = A_0.GetString("LocaleNarrationTrigger+_Text");
		this.b = (Guid?)A_0.GetValue("LocaleNarrationTrigger+_Speaker", typeof(Guid?));
		try
		{
			this.c = A_0.GetBoolean("LocaleNarrationTrigger+_InterruptTalking");
		}
		catch
		{
		}
	}

	// Token: 0x06006395 RID: 25493 RVA: 0x002AED54 File Offset: 0x002ACF54
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("LNT:T", this.a);
		info.AddValue("LNT:S", this.b);
		info.AddValue("LNT:IT", this.c);
	}

	// Token: 0x06006396 RID: 25494 RVA: 0x002AEDA4 File Offset: 0x002ACFA4
	public string a()
	{
		return this.a;
	}

	// Token: 0x06006397 RID: 25495 RVA: 0x002AEDAC File Offset: 0x002ACFAC
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006398 RID: 25496 RVA: 0x002AEDB8 File Offset: 0x002ACFB8
	public Guid? b()
	{
		return this.b;
	}

	// Token: 0x06006399 RID: 25497 RVA: 0x002AEDC0 File Offset: 0x002ACFC0
	public void a(Guid? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600639A RID: 25498 RVA: 0x002AEDCC File Offset: 0x002ACFCC
	public bool c()
	{
		return this.c;
	}

	// Token: 0x0600639B RID: 25499 RVA: 0x002AEDD4 File Offset: 0x002ACFD4
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600639C RID: 25500 RVA: 0x002AEDE0 File Offset: 0x002ACFE0
	public d9s()
	{
	}

	// Token: 0x0600639D RID: 25501 RVA: 0x002AEDF0 File Offset: 0x002ACFF0
	protected override void adf(c5x A_0)
	{
		if (this.b != null && A_0.Area != null)
		{
			c5x c5x = A_0.Area.a(this.b.Value) as c5x;
			if (c5x != null && c5x.u.b != null)
			{
				if (c5x.aa)
				{
					c5x c5x2 = vq.a(c5x);
					if (c5x2 != null)
					{
						c5x2.u.b.a(this.a, this.c, null, null);
						return;
					}
				}
				else
				{
					c5x.u.b.a(this.a, this.c, null, null);
				}
			}
		}
	}

	// Token: 0x040029ED RID: 10733
	private string a;

	// Token: 0x040029EE RID: 10734
	private Guid? b;

	// Token: 0x040029EF RID: 10735
	private bool c = true;
}
