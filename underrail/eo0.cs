using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x02000FC2 RID: 4034
[eiz("CCRCC")]
[Serializable]
public sealed class eo0 : dnh, ISerializable
{
	// Token: 0x060052CE RID: 21198 RVA: 0x0024EE80 File Offset: 0x0024D080
	private eo0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid?)A_0.GetValue("CCRCC:I", typeof(Guid?));
		this.b = A_0.GetString("CCRCC:A");
		this.c = A_0.GetBoolean("CCRCC:N");
		this.d = A_0.GetString("CCRCC:RCC");
		this.e = A_0.GetBoolean("CCRCC:M");
	}

	// Token: 0x060052CF RID: 21199 RVA: 0x0024EEFC File Offset: 0x0024D0FC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CCRCC:I", this.a);
		info.AddValue("CCRCC:A", this.b);
		info.AddValue("CCRCC:N", this.c);
		info.AddValue("CCRCC:RCC", this.d);
		info.AddValue("CCRCC:M", this.e);
	}

	// Token: 0x060052D0 RID: 21200 RVA: 0x0024EF6C File Offset: 0x0024D16C
	public string e()
	{
		return this.b;
	}

	// Token: 0x060052D1 RID: 21201 RVA: 0x0024EF74 File Offset: 0x0024D174
	public void b(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060052D2 RID: 21202 RVA: 0x0024EF80 File Offset: 0x0024D180
	public Guid? d()
	{
		return this.a;
	}

	// Token: 0x060052D3 RID: 21203 RVA: 0x0024EF88 File Offset: 0x0024D188
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060052D4 RID: 21204 RVA: 0x0024EF94 File Offset: 0x0024D194
	public bool a()
	{
		return this.c;
	}

	// Token: 0x060052D5 RID: 21205 RVA: 0x0024EF9C File Offset: 0x0024D19C
	public void b(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060052D6 RID: 21206 RVA: 0x0024EFA8 File Offset: 0x0024D1A8
	public string c()
	{
		return this.d;
	}

	// Token: 0x060052D7 RID: 21207 RVA: 0x0024EFB0 File Offset: 0x0024D1B0
	public void c(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060052D8 RID: 21208 RVA: 0x0024EFBC File Offset: 0x0024D1BC
	public bool b()
	{
		return this.e;
	}

	// Token: 0x060052D9 RID: 21209 RVA: 0x0024EFC4 File Offset: 0x0024D1C4
	public void a(bool A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060052DA RID: 21210 RVA: 0x0024EFD0 File Offset: 0x0024D1D0
	public eo0()
	{
	}

	// Token: 0x060052DB RID: 21211 RVA: 0x0024EFD8 File Offset: 0x0024D1D8
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		bool flag = false;
		if (!string.IsNullOrWhiteSpace(this.d))
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqw() != null)
			{
				b0b b0b = null;
				if (this.a != null)
				{
					aud aud = null;
					if (!string.IsNullOrEmpty(this.b))
					{
						aud = serviceOrThrow.aqw().n(this.b);
					}
					else
					{
						b0b b0b2 = A_0.GetPropertyValue(c49.a) as b0b;
						b0b b0b3 = A_0.GetPropertyValue(c49.b) as b0b;
						if (b0b3 != null && b0b3.Area != null)
						{
							aud = b0b3.Area;
						}
						else if (b0b2 != null && b0b2.Area != null)
						{
							aud = b0b2.Area;
						}
					}
					if (aud != null)
					{
						b0b = new ar7(this.a.Value, aud).ao();
					}
				}
				else
				{
					c5x c5x = A_0.get_Item(c49.a) as c5x;
					if (c5x != null && !c5x.IsPlayer)
					{
						b0b = (A_0.GetPropertyValue(c49.a) as b0b);
					}
					else
					{
						b0b = (A_0.GetPropertyValue(c49.b) as b0b);
					}
				}
				if (b0b != null)
				{
					e3l aspect = b0b.GetAspect<e3l>();
					if (aspect != null)
					{
						if (this.e)
						{
							flag = aspect.a.Contains(this.d);
						}
						else
						{
							flag = Enumerable.Any<string>(aspect.a, new Func<string, bool>(this.a));
						}
					}
				}
			}
		}
		return flag ^ this.c;
	}

	// Token: 0x060052DC RID: 21212 RVA: 0x0024F16C File Offset: 0x0024D36C
	[CompilerGenerated]
	private bool a(string A_0)
	{
		return A_0.Contains(this.d);
	}

	// Token: 0x040021E4 RID: 8676
	private Guid? a;

	// Token: 0x040021E5 RID: 8677
	private string b;

	// Token: 0x040021E6 RID: 8678
	private bool c;

	// Token: 0x040021E7 RID: 8679
	private string d;

	// Token: 0x040021E8 RID: 8680
	private bool e;
}
