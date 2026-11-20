using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Generators.Items;

// Token: 0x02001124 RID: 4388
[eiz("GIJ")]
[Serializable]
public sealed class mk : cze, ISerializable
{
	// Token: 0x06005DC1 RID: 24001 RVA: 0x0027C810 File Offset: 0x0027AA10
	private mk(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (dcw)A_0.GetValue("GIJ:SI", typeof(dcw));
			this.b = (c9y)A_0.GetValue("GIJ:DI", typeof(c9y));
			this.c = (bvl)A_0.GetValue("GIJ:GT", typeof(bvl));
			this.d = A_0.GetBoolean("GIJ:PEFP");
			if (ell.a() >= 519)
			{
				this.e = (A_0.GetValue("GIJ:AE", typeof(AutoEquipMode?)) as AutoEquipMode?);
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(mk))
			{
				this.a = (dcw)A_0.GetValue("_StaticItems", typeof(dcw));
				this.b = (c9y)A_0.GetValue("_DynamicItems", typeof(c9y));
				this.c = (bvl)A_0.GetValue("_GiveTo", typeof(bvl));
				this.d = A_0.GetBoolean("_PublishEventsForPlayer");
				return;
			}
			this.a = (dcw)A_0.GetValue("GiveItemsJob+_StaticItems", typeof(dcw));
			this.b = (c9y)A_0.GetValue("GiveItemsJob+_DynamicItems", typeof(c9y));
			this.c = (bvl)A_0.GetValue("GiveItemsJob+_GiveTo", typeof(bvl));
			this.d = A_0.GetBoolean("GiveItemsJob+_PublishEventsForPlayer");
		}
	}

	// Token: 0x06005DC2 RID: 24002 RVA: 0x0027C9F8 File Offset: 0x0027ABF8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("GIJ:SI", this.a);
		info.AddValue("GIJ:DI", this.b);
		info.AddValue("GIJ:GT", this.c);
		info.AddValue("GIJ:PEFP", this.d);
		info.AddValue("GIJ:AE", this.e);
	}

	// Token: 0x170001C8 RID: 456
	// (get) Token: 0x06005DC3 RID: 24003 RVA: 0x0027CA6C File Offset: 0x0027AC6C
	// (set) Token: 0x06005DC4 RID: 24004 RVA: 0x0027CA74 File Offset: 0x0027AC74
	public dcw StaticItems
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

	// Token: 0x170001C9 RID: 457
	// (get) Token: 0x06005DC5 RID: 24005 RVA: 0x0027CA80 File Offset: 0x0027AC80
	// (set) Token: 0x06005DC6 RID: 24006 RVA: 0x0027CA88 File Offset: 0x0027AC88
	public c9y DynamicItems
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

	// Token: 0x170001CA RID: 458
	// (get) Token: 0x06005DC7 RID: 24007 RVA: 0x0027CA94 File Offset: 0x0027AC94
	// (set) Token: 0x06005DC8 RID: 24008 RVA: 0x0027CA9C File Offset: 0x0027AC9C
	public bvl GiveTo
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

	// Token: 0x170001CB RID: 459
	// (get) Token: 0x06005DC9 RID: 24009 RVA: 0x0027CAA8 File Offset: 0x0027ACA8
	// (set) Token: 0x06005DCA RID: 24010 RVA: 0x0027CAB0 File Offset: 0x0027ACB0
	public bool PublishEventsForPlayer
	{
		get
		{
			return this.d;
		}
		set
		{
			this.d = value;
		}
	}

	// Token: 0x170001CC RID: 460
	// (get) Token: 0x06005DCB RID: 24011 RVA: 0x0027CABC File Offset: 0x0027ACBC
	// (set) Token: 0x06005DCC RID: 24012 RVA: 0x0027CAC4 File Offset: 0x0027ACC4
	public AutoEquipMode? AutoEquipMode
	{
		get
		{
			return this.e;
		}
		set
		{
			this.e = value;
		}
	}

	// Token: 0x06005DCD RID: 24013 RVA: 0x0027CAD0 File Offset: 0x0027ACD0
	public mk()
	{
	}

	// Token: 0x06005DCE RID: 24014 RVA: 0x0027CB00 File Offset: 0x0027AD00
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		efk efk = null;
		int num = 0;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		switch (this.c)
		{
		case bvl.b:
			if (A_0 != null)
			{
				amc aspect = A_0.GetAspect<amc>();
				if (aspect != null)
				{
					efk = aspect.aa();
				}
			}
			break;
		case bvl.c:
			if (A_1 != null)
			{
				amc aspect2 = A_1.GetAspect<amc>();
				if (aspect2 != null)
				{
					efk = aspect2.aa();
				}
			}
			break;
		case bvl.d:
			if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
			{
				efk = serviceOrThrow.aqu().v();
			}
			break;
		}
		bool flag = this.d && serviceOrThrow != null && serviceOrThrow.aqu() != null && efk == serviceOrThrow.aqu().v();
		if (efk != null)
		{
			if (this.a != null)
			{
				foreach (coh coh in this.a.z2())
				{
					mk.a(coh, efk);
					if (this.e == null || this.e.Value == TimelapseVertigo.Generators.Items.AutoEquipMode.None || !bn.a(efk, coh, this.e.Value, ref num))
					{
						efk.Bag.z3(coh, true);
					}
					if (flag)
					{
						a7v.a(new bou(coh));
					}
				}
			}
			if (this.b != null)
			{
				List<bmd> list = this.b.c();
				if (list != null)
				{
					foreach (bmd bmd in list)
					{
						if (bmd.Item != null)
						{
							mk.a(bmd.Item, efk);
							if (this.e == null || this.e.Value == TimelapseVertigo.Generators.Items.AutoEquipMode.None || !bn.a(efk, bmd.Item, this.e ?? bmd.AutoEquipMode, ref num))
							{
								efk.Bag.z3(bmd.Item, true);
							}
							if (flag)
							{
								a7v.a(new bou(bmd.Item));
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005DCF RID: 24015 RVA: 0x0027CD8C File Offset: 0x0027AF8C
	private static void a(coh A_0, efk A_1)
	{
		if (A_1 is e3q)
		{
			A_0.Lootable = true;
			A_0.Stealable = true;
		}
	}

	// Token: 0x04002552 RID: 9554
	private new dcw a = new dcw();

	// Token: 0x04002553 RID: 9555
	private c9y b = new c9y();

	// Token: 0x04002554 RID: 9556
	private bvl c = bvl.c;

	// Token: 0x04002555 RID: 9557
	private bool d = true;

	// Token: 0x04002556 RID: 9558
	private AutoEquipMode? e;
}
