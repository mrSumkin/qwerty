using System;
using System.Runtime.Serialization;

// Token: 0x02001854 RID: 6228
[eiz("UEA1")]
[Serializable]
public sealed class c7 : dvv, ISerializable
{
	// Token: 0x060084CE RID: 33998 RVA: 0x00373610 File Offset: 0x00371810
	private c7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (ar7)A_0.GetValue("UEA1:ER", typeof(ar7));
			this.b = A_0.GetBoolean("UEA1:DRE");
			this.c = A_0.GetBoolean("UEA1:WFSFF");
			if (ell.a() > 12)
			{
				this.d = A_0.GetBoolean("UEA1:WFNLS");
			}
			if (ell.a() >= 324)
			{
				this.e = A_0.GetBoolean("UEA1:AI");
			}
			else
			{
				this.e = true;
			}
			if (ell.a() >= 367)
			{
				this.f = A_0.GetBoolean("UEA1:FD");
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(c7))
			{
				this.a = (ar7)A_0.GetValue("_EntityReference", typeof(ar7));
				this.b = A_0.GetBoolean("_DestroyRaysEmitters");
				this.c = A_0.GetBoolean("_WaitForSctFeedFlush");
				return;
			}
			this.a = (ar7)A_0.GetValue("UndeployEntityAction+_EntityReference", typeof(ar7));
			this.b = A_0.GetBoolean("UndeployEntityAction+_DestroyRaysEmitters");
			this.c = A_0.GetBoolean("UndeployEntityAction+_WaitForSctFeedFlush");
		}
	}

	// Token: 0x060084CF RID: 33999 RVA: 0x00373784 File Offset: 0x00371984
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("UEA1:ER", this.a);
		info.AddValue("UEA1:DRE", this.b);
		info.AddValue("UEA1:WFSFF", this.c);
		info.AddValue("UEA1:WFNLS", this.d);
		info.AddValue("UEA1:AI", this.e);
		info.AddValue("UEA1:FD", this.f);
	}

	// Token: 0x060084D0 RID: 34000 RVA: 0x00373800 File Offset: 0x00371A00
	private b0b b()
	{
		return this.a.ao();
	}

	// Token: 0x060084D1 RID: 34001 RVA: 0x00373810 File Offset: 0x00371A10
	public bool c()
	{
		return this.b;
	}

	// Token: 0x060084D2 RID: 34002 RVA: 0x00373818 File Offset: 0x00371A18
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060084D3 RID: 34003 RVA: 0x00373824 File Offset: 0x00371A24
	public c7(b0b A_0, bool A_1 = false, bool A_2 = false, bool A_3 = true, bool A_4 = false)
	{
		czh.a(A_0, "entity");
		this.c = A_1;
		this.d = A_2;
		this.e = A_3;
		this.f = A_4;
		this.a = new ar7(A_0);
	}

	// Token: 0x060084D4 RID: 34004 RVA: 0x00373874 File Offset: 0x00371A74
	protected override dc4 dt()
	{
		if (this.e)
		{
			return this.a();
		}
		return dc4.b;
	}

	// Token: 0x060084D5 RID: 34005 RVA: 0x0037388C File Offset: 0x00371A8C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		return this.a();
	}

	// Token: 0x060084D6 RID: 34006 RVA: 0x00373894 File Offset: 0x00371A94
	private dc4 a()
	{
		if (this.b() == null || this.b().j != cgy.b)
		{
			return dc4.c;
		}
		cmh cmh;
		if (this.c)
		{
			cmh = bmj.b(this.b());
		}
		else
		{
			cmh = null;
		}
		c5x c5x = this.b() as c5x;
		bool flag = c5x != null && c5x.v.b != null && c5x.v.b.b();
		if ((!this.c || cmh == null || this.f) && (!this.d || !flag || this.f))
		{
			if (flag && this.f)
			{
				c5x.v.b.a(false);
			}
			if (cmh != null && this.f)
			{
				bmj.a(this.b());
			}
			if (this.b)
			{
				this.b().w();
			}
			this.b().an();
			return dc4.c;
		}
		return dc4.b;
	}

	// Token: 0x040032E6 RID: 13030
	private new ar7 a;

	// Token: 0x040032E7 RID: 13031
	private bool b;

	// Token: 0x040032E8 RID: 13032
	private bool c;

	// Token: 0x040032E9 RID: 13033
	private bool d;

	// Token: 0x040032EA RID: 13034
	private bool e = true;

	// Token: 0x040032EB RID: 13035
	private bool f;
}
