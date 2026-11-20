using System;
using System.Runtime.Serialization;

// Token: 0x02000FDD RID: 4061
[eiz("RHV")]
[Serializable]
public sealed class d4r : esc, ISerializable
{
	// Token: 0x0600539B RID: 21403 RVA: 0x00250FF0 File Offset: 0x0024F1F0
	private d4r(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("RHV:A");
		this.b = A_0.GetInt32("RHV:M");
		this.c = A_0.GetBoolean("RHV:P");
	}

	// Token: 0x0600539C RID: 21404 RVA: 0x00251038 File Offset: 0x0024F238
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("RHV:A", this.a);
		info.AddValue("RHV:M", this.b);
		info.AddValue("RHV:P", this.c);
	}

	// Token: 0x0600539D RID: 21405 RVA: 0x00251080 File Offset: 0x0024F280
	public bool a()
	{
		return this.a;
	}

	// Token: 0x0600539E RID: 21406 RVA: 0x00251088 File Offset: 0x0024F288
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600539F RID: 21407 RVA: 0x00251094 File Offset: 0x0024F294
	public int b()
	{
		return this.b;
	}

	// Token: 0x060053A0 RID: 21408 RVA: 0x0025109C File Offset: 0x0024F29C
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060053A1 RID: 21409 RVA: 0x002510A8 File Offset: 0x0024F2A8
	public bool c()
	{
		return this.c;
	}

	// Token: 0x060053A2 RID: 21410 RVA: 0x002510B0 File Offset: 0x0024F2B0
	public void b(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060053A3 RID: 21411 RVA: 0x002510BC File Offset: 0x0024F2BC
	public d4r()
	{
	}

	// Token: 0x060053A4 RID: 21412 RVA: 0x002510C8 File Offset: 0x0024F2C8
	public override int d5(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null)
		{
			c5x c5x = A_0.get_Item(c49.a) as c5x;
			c5x c5x2 = A_0.get_Item(c49.b) as c5x;
			if (c5x != null && c5x.h.b != null && c5x2 != null && c5x2.h.b != null)
			{
				c5x c5x3;
				c5x c5x4;
				if (c5x.IsPlayer)
				{
					c5x3 = c5x;
					c5x4 = c5x2;
				}
				else
				{
					c5x3 = c5x2;
					c5x4 = c5x;
				}
				if (this.b != 0)
				{
					d02 service = bpo.GetService<d02>();
					if (service != null)
					{
						service.ah3(this.b);
					}
				}
				a27 a_;
				if (this.c)
				{
					a_ = new a27(c5x3.h.b, c5x4.h.b, false, false, this.a, true);
				}
				else
				{
					a_ = new a27(c5x4.h.b, c5x3.h.b, false, false, this.a, true);
				}
				serviceOrThrow.aqw().ActionManager.g9(a_, atp.a);
			}
		}
		return 1;
	}

	// Token: 0x04002218 RID: 8728
	private bool a;

	// Token: 0x04002219 RID: 8729
	private int b;

	// Token: 0x0400221A RID: 8730
	private bool c;
}
