using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

// Token: 0x0200112D RID: 4397
[eiz("SIJ")]
[Serializable]
public sealed class a72 : cze, ISerializable
{
	// Token: 0x06005E14 RID: 24084 RVA: 0x0027DC50 File Offset: 0x0027BE50
	private a72(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("SIJ:D");
			this.b = A_0.GetString("SIJ:OIAN");
			this.c = A_0.GetString("SIJ:IAI");
			this.d = A_0.GetBoolean("SIJ:AIC");
			if (ell.a() >= 36)
			{
				this.e = A_0.GetBoolean("SIJ:FT");
			}
			else
			{
				this.e = true;
			}
			if (ell.a() >= 40)
			{
				this.f = A_0.GetBoolean("SIJ:UPU");
			}
			if (ell.a() >= 312)
			{
				this.g = (A_0.GetValue("SIJ:O", typeof(Guid?)) as Guid?);
			}
			if (ell.a() >= 609)
			{
				this.h = A_0.GetString("SIJ:P");
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(a72))
			{
				this.a = A_0.GetString("_Dialog");
				this.b = A_0.GetString("_OverrideInterfaceActorName");
				this.c = A_0.GetString("_InterfaceActorId");
				this.d = A_0.GetBoolean("_AllowInCombat");
				return;
			}
			this.a = A_0.GetString("StartInterfacingJob+_Dialog");
			this.b = A_0.GetString("StartInterfacingJob+_OverrideInterfaceActorName");
			this.c = A_0.GetString("StartInterfacingJob+_InterfaceActorId");
			this.d = A_0.GetBoolean("StartInterfacingJob+_AllowInCombat");
		}
	}

	// Token: 0x06005E15 RID: 24085 RVA: 0x0027DE04 File Offset: 0x0027C004
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SIJ:D", this.a);
		info.AddValue("SIJ:OIAN", this.b);
		info.AddValue("SIJ:IAI", this.c);
		info.AddValue("SIJ:AIC", this.d);
		info.AddValue("SIJ:FT", this.e);
		info.AddValue("SIJ:UPU", this.f);
		info.AddValue("SIJ:O", this.g);
		info.AddValue("SIJ:P", this.h);
	}

	// Token: 0x06005E16 RID: 24086 RVA: 0x0027DEA8 File Offset: 0x0027C0A8
	public Guid? f()
	{
		return this.g;
	}

	// Token: 0x06005E17 RID: 24087 RVA: 0x0027DEB0 File Offset: 0x0027C0B0
	public void a(Guid? A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06005E18 RID: 24088 RVA: 0x0027DEBC File Offset: 0x0027C0BC
	public string d()
	{
		return this.a;
	}

	// Token: 0x06005E19 RID: 24089 RVA: 0x0027DEC4 File Offset: 0x0027C0C4
	public void b(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005E1A RID: 24090 RVA: 0x0027DED0 File Offset: 0x0027C0D0
	public string e()
	{
		return this.b;
	}

	// Token: 0x06005E1B RID: 24091 RVA: 0x0027DED8 File Offset: 0x0027C0D8
	public void c(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005E1C RID: 24092 RVA: 0x0027DEE4 File Offset: 0x0027C0E4
	public string c()
	{
		return this.c;
	}

	// Token: 0x06005E1D RID: 24093 RVA: 0x0027DEEC File Offset: 0x0027C0EC
	public void d(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005E1E RID: 24094 RVA: 0x0027DEF8 File Offset: 0x0027C0F8
	public bool h()
	{
		return this.d;
	}

	// Token: 0x06005E1F RID: 24095 RVA: 0x0027DF00 File Offset: 0x0027C100
	public void a(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005E20 RID: 24096 RVA: 0x0027DF0C File Offset: 0x0027C10C
	public bool a()
	{
		return this.e;
	}

	// Token: 0x06005E21 RID: 24097 RVA: 0x0027DF14 File Offset: 0x0027C114
	public void c(bool A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06005E22 RID: 24098 RVA: 0x0027DF20 File Offset: 0x0027C120
	public bool b()
	{
		return this.f;
	}

	// Token: 0x06005E23 RID: 24099 RVA: 0x0027DF28 File Offset: 0x0027C128
	public void b(bool A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06005E24 RID: 24100 RVA: 0x0027DF34 File Offset: 0x0027C134
	public string g()
	{
		return this.h;
	}

	// Token: 0x06005E25 RID: 24101 RVA: 0x0027DF3C File Offset: 0x0027C13C
	public void a(string A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06005E26 RID: 24102 RVA: 0x0027DF48 File Offset: 0x0027C148
	public a72()
	{
	}

	// Token: 0x06005E27 RID: 24103 RVA: 0x0027DF64 File Offset: 0x0027C164
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (d8s.b() && d8s.a(this.a))
		{
			d8s.a();
			return;
		}
		ps service = bpo.GetService<ps>();
		if (service != null)
		{
			c5x c5x;
			if (this.g != null)
			{
				c5x = (new ar7(this.g.Value, A_0.Area).ao() as c5x);
			}
			else
			{
				c5x = (A_1 as c5x);
			}
			if (c5x != null && !this.f && !c5x.a())
			{
				return;
			}
			List<ble> list = new List<ble>();
			j7 aspect = A_0.GetAspect<j7>();
			if (aspect != null)
			{
				list.Add(aspect);
			}
			x4 x = new x4();
			x.a(c5x);
			x.a(this.c);
			x.c((!string.IsNullOrEmpty(this.e())) ? this.e() : c5x.y8());
			x.b(this.h);
			list.Add(x);
			list.AddRange(a37.a(A_0.Area));
			list = Enumerable.ToList<ble>(Enumerable.Distinct<ble>(list));
			PropertyCollection a_ = null;
			object obj;
			if (A_2 != null && A_2.TryGetValue("tempContext", out obj))
			{
				a_ = (obj as PropertyCollection);
			}
			service.amu(this.a, A_0, c5x, list, this.d, false, this.e, a_, true, false);
		}
	}

	// Token: 0x0400256D RID: 9581
	private new string a;

	// Token: 0x0400256E RID: 9582
	private string b;

	// Token: 0x0400256F RID: 9583
	private string c = "interface";

	// Token: 0x04002570 RID: 9584
	private bool d;

	// Token: 0x04002571 RID: 9585
	private bool e = true;

	// Token: 0x04002572 RID: 9586
	private bool f;

	// Token: 0x04002573 RID: 9587
	private Guid? g;

	// Token: 0x04002574 RID: 9588
	private string h;
}
