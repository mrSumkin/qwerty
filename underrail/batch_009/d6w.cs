using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x02000667 RID: 1639
[eiz("MS1")]
[Serializable]
public sealed class d6w : ISerializable
{
	// Token: 0x060029A6 RID: 10662 RVA: 0x000ECCA0 File Offset: 0x000EAEA0
	private d6w(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("MS1:N");
			this.b = (dcw)A_0.GetValue("MS1:SI", typeof(dcw));
			this.c = (c9y)A_0.GetValue("MS1:DI", typeof(c9y));
			this.d = (dth)A_0.GetValue("MS1:C", typeof(dth));
			this.e = A_0.GetBoolean("MS1:ROM");
			if (ell.a() >= 346)
			{
				this.f = A_0.GetBoolean("MS1:S");
			}
			if (ell.a() >= 407)
			{
				this.g = A_0.GetString("MS1:D");
			}
			if (ell.a() >= 476)
			{
				this.h = A_0.GetBoolean("MS1:U");
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(d6w))
			{
				this.a = A_0.GetString("_Name");
				this.b = (dcw)A_0.GetValue("_StaticItems", typeof(dcw));
				this.c = (c9y)A_0.GetValue("_DynamicItems", typeof(c9y));
				this.d = (dth)A_0.GetValue("_Condition", typeof(dth));
				this.e = A_0.GetBoolean("_RemoveOldMerchandise");
				return;
			}
			this.a = A_0.GetString("MerchandiseShipment+_Name");
			this.b = (dcw)A_0.GetValue("MerchandiseShipment+_StaticItems", typeof(dcw));
			this.c = (c9y)A_0.GetValue("MerchandiseShipment+_DynamicItems", typeof(c9y));
			this.d = (dth)A_0.GetValue("MerchandiseShipment+_Condition", typeof(dth));
			this.e = A_0.GetBoolean("MerchandiseShipment+_RemoveOldMerchandise");
		}
	}

	// Token: 0x060029A7 RID: 10663 RVA: 0x000ECEC0 File Offset: 0x000EB0C0
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("MS1:N", this.a);
		info.AddValue("MS1:SI", this.b);
		info.AddValue("MS1:DI", this.c);
		info.AddValue("MS1:C", this.d);
		info.AddValue("MS1:ROM", this.e);
		info.AddValue("MS1:S", this.f);
		info.AddValue("MS1:D", this.g);
		info.AddValue("MS1:U", this.h);
	}

	// Token: 0x060029A8 RID: 10664 RVA: 0x000ECF58 File Offset: 0x000EB158
	public string d()
	{
		return this.a;
	}

	// Token: 0x060029A9 RID: 10665 RVA: 0x000ECF60 File Offset: 0x000EB160
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060029AA RID: 10666 RVA: 0x000ECF6C File Offset: 0x000EB16C
	public dcw i()
	{
		return this.b;
	}

	// Token: 0x060029AB RID: 10667 RVA: 0x000ECF74 File Offset: 0x000EB174
	public void a(dcw A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060029AC RID: 10668 RVA: 0x000ECF80 File Offset: 0x000EB180
	public c9y g()
	{
		return this.c;
	}

	// Token: 0x060029AD RID: 10669 RVA: 0x000ECF88 File Offset: 0x000EB188
	public void a(c9y A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060029AE RID: 10670 RVA: 0x000ECF94 File Offset: 0x000EB194
	public dth h()
	{
		return this.d;
	}

	// Token: 0x060029AF RID: 10671 RVA: 0x000ECF9C File Offset: 0x000EB19C
	public void a(dth A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060029B0 RID: 10672 RVA: 0x000ECFA8 File Offset: 0x000EB1A8
	public bool b()
	{
		return this.e;
	}

	// Token: 0x060029B1 RID: 10673 RVA: 0x000ECFB0 File Offset: 0x000EB1B0
	public void c(bool A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060029B2 RID: 10674 RVA: 0x000ECFBC File Offset: 0x000EB1BC
	public bool e()
	{
		return this.f;
	}

	// Token: 0x060029B3 RID: 10675 RVA: 0x000ECFC4 File Offset: 0x000EB1C4
	public void b(bool A_0)
	{
		this.f = A_0;
	}

	// Token: 0x060029B4 RID: 10676 RVA: 0x000ECFD0 File Offset: 0x000EB1D0
	public string f()
	{
		return this.g;
	}

	// Token: 0x060029B5 RID: 10677 RVA: 0x000ECFD8 File Offset: 0x000EB1D8
	public void b(string A_0)
	{
		this.g = A_0;
	}

	// Token: 0x060029B6 RID: 10678 RVA: 0x000ECFE4 File Offset: 0x000EB1E4
	public bool a()
	{
		return this.h;
	}

	// Token: 0x060029B7 RID: 10679 RVA: 0x000ECFEC File Offset: 0x000EB1EC
	public void a(bool A_0)
	{
		this.h = A_0;
	}

	// Token: 0x060029B8 RID: 10680 RVA: 0x000ECFF8 File Offset: 0x000EB1F8
	public d6w()
	{
	}

	// Token: 0x060029B9 RID: 10681 RVA: 0x000ED004 File Offset: 0x000EB204
	public List<coh> c()
	{
		List<coh> list = new List<coh>();
		if (this.b != null)
		{
			list.AddRange(this.b.z2());
		}
		if (this.c != null)
		{
			List<bmd> list2 = this.c.c();
			if (list2 != null)
			{
				list.AddRange(Enumerable.Select<bmd, coh>(Enumerable.Where<bmd>(list2, new Func<bmd, bool>(d6w.a.a.b)), new Func<bmd, coh>(d6w.a.a.a)));
			}
		}
		return list;
	}

	// Token: 0x060029BA RID: 10682 RVA: 0x000ED0A8 File Offset: 0x000EB2A8
	public d6w j()
	{
		d6w d6w = new d6w();
		d6w.d = this.d;
		d6w.c = this.c.e();
		d6w.a = this.a;
		d6w.e = this.e;
		d6w.b = new dcw();
		d6w.b.z2().AddRange(this.b.z2());
		d6w.f = this.f;
		d6w.g = this.g;
		return d6w;
	}

	// Token: 0x040016AF RID: 5807
	private string a;

	// Token: 0x040016B0 RID: 5808
	private dcw b;

	// Token: 0x040016B1 RID: 5809
	private c9y c;

	// Token: 0x040016B2 RID: 5810
	private dth d;

	// Token: 0x040016B3 RID: 5811
	private bool e;

	// Token: 0x040016B4 RID: 5812
	private bool f;

	// Token: 0x040016B5 RID: 5813
	private string g;

	// Token: 0x040016B6 RID: 5814
	private bool h;

	// Token: 0x02000668 RID: 1640
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x060029BD RID: 10685 RVA: 0x000ED144 File Offset: 0x000EB344
		internal bool b(bmd A_0)
		{
			return A_0.Item != null;
		}

		// Token: 0x060029BE RID: 10686 RVA: 0x000ED150 File Offset: 0x000EB350
		internal coh a(bmd A_0)
		{
			return A_0.Item;
		}

		// Token: 0x040016B7 RID: 5815
		public static readonly d6w.a a = new d6w.a();

		// Token: 0x040016B8 RID: 5816
		public static Func<bmd, bool> b;

		// Token: 0x040016B9 RID: 5817
		public static Func<bmd, coh> c;
	}
}
