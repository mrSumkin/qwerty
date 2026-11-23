using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010F8 RID: 4344
[eiz("R0")]
[Serializable]
public sealed class bir : cze, ISerializable
{
	// Token: 0x06005C09 RID: 23561 RVA: 0x00276F24 File Offset: 0x00275124
	private bir(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("R0:S", typeof(Guid?)) as Guid?);
		if (ell.a() >= 184)
		{
			this.b = (A_0.GetValue("R0:T", typeof(Guid?)) as Guid?);
			this.d = A_0.GetBoolean("R0:Y");
			this.e = A_0.GetInt32("R0:M");
		}
		else
		{
			this.b = new Guid?((Guid)A_0.GetValue("R0:T", typeof(Guid)));
		}
		this.c = A_0.GetString("R0:A");
	}

	// Token: 0x06005C0A RID: 23562 RVA: 0x00276FF0 File Offset: 0x002751F0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("R0:S", this.a);
		info.AddValue("R0:T", this.b);
		info.AddValue("R0:A", this.c);
		info.AddValue("R0:Y", this.d);
		info.AddValue("R0:M", this.e);
	}

	// Token: 0x06005C0B RID: 23563 RVA: 0x00277064 File Offset: 0x00275264
	public Guid? d()
	{
		return this.a;
	}

	// Token: 0x06005C0C RID: 23564 RVA: 0x0027706C File Offset: 0x0027526C
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005C0D RID: 23565 RVA: 0x00277078 File Offset: 0x00275278
	public Guid? a()
	{
		return this.b;
	}

	// Token: 0x06005C0E RID: 23566 RVA: 0x00277080 File Offset: 0x00275280
	public void b(Guid? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005C0F RID: 23567 RVA: 0x0027708C File Offset: 0x0027528C
	public string e()
	{
		return this.c;
	}

	// Token: 0x06005C10 RID: 23568 RVA: 0x00277094 File Offset: 0x00275294
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005C11 RID: 23569 RVA: 0x002770A0 File Offset: 0x002752A0
	public bool b()
	{
		return this.d;
	}

	// Token: 0x06005C12 RID: 23570 RVA: 0x002770A8 File Offset: 0x002752A8
	public void a(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005C13 RID: 23571 RVA: 0x002770B4 File Offset: 0x002752B4
	public int c()
	{
		return this.e;
	}

	// Token: 0x06005C14 RID: 23572 RVA: 0x002770BC File Offset: 0x002752BC
	public void a(int A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06005C15 RID: 23573 RVA: 0x002770C8 File Offset: 0x002752C8
	public bir()
	{
	}

	// Token: 0x06005C16 RID: 23574 RVA: 0x002770D4 File Offset: 0x002752D4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (this.e != 0)
		{
			d02 service = bpo.GetService<d02>();
			if (service != null)
			{
				service.ah3(this.e);
			}
		}
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null)
		{
			aud aud = null;
			if (!string.IsNullOrEmpty(this.c))
			{
				aud = serviceOrThrow.aqw().n(this.c);
			}
			else if (serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
			{
				aud = serviceOrThrow.aqu().v().b().Area;
			}
			if (aud != null)
			{
				c5x c5x = (serviceOrThrow.aqu().v() != null) ? (serviceOrThrow.aqu().v().b() as c5x) : null;
				c5x c5x2;
				if (this.a != null)
				{
					c5x2 = (new ar7(this.a.Value, aud).ao() as c5x);
				}
				else
				{
					c5x2 = c5x;
				}
				c5x c5x3;
				if (this.b != null)
				{
					c5x3 = (new ar7(this.b.Value, aud).ao() as c5x);
				}
				else
				{
					c5x3 = c5x;
				}
				if (c5x2 != null && c5x2.h.b != null && c5x3 != null && c5x3.h.b != null)
				{
					a27 a_ = new a27(c5x2.h.b, c5x3.h.b, false, false, this.d, true);
					serviceOrThrow.aqw().ActionManager.g9(a_, atp.a);
				}
			}
		}
	}

	// Token: 0x040024C2 RID: 9410
	private new Guid? a;

	// Token: 0x040024C3 RID: 9411
	private Guid? b;

	// Token: 0x040024C4 RID: 9412
	private string c;

	// Token: 0x040024C5 RID: 9413
	private bool d;

	// Token: 0x040024C6 RID: 9414
	private int e;
}
