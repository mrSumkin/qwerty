using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001330 RID: 4912
[eiz("CISA")]
[Serializable]
public sealed class dsr : dvv, ISerializable
{
	// Token: 0x06006F41 RID: 28481 RVA: 0x002EB4F4 File Offset: 0x002E96F4
	private dsr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (ar7)A_0.GetValue("CISA:SR", typeof(ar7));
			this.b = (ar7)A_0.GetValue("CISA:ETR", typeof(ar7));
			this.c = (edx)A_0.GetValue("CISA:TTR", typeof(edx));
			this.d = A_0.GetSingle("CISA:R");
			this.e = (e6z)A_0.GetValue("CISA:DAR", typeof(e6z));
			this.f = (Point)A_0.GetValue("CISA:DN", typeof(Point));
			this.g = (bool?)A_0.GetValue("CISA:R1", typeof(bool?));
			if (ell.a() >= 706)
			{
				di7.ReadList<byte>("CISA:AO", ref this.h, A_0);
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(dsr))
			{
				this.a = (ar7)A_0.GetValue("_SourceRef", typeof(ar7));
				this.b = (ar7)A_0.GetValue("_EntityTargetRef", typeof(ar7));
				this.c = (edx)A_0.GetValue("_TileTargetRef", typeof(edx));
				this.d = A_0.GetSingle("_Range");
				this.e = (e6z)A_0.GetValue("_DestinationAreaRef", typeof(e6z));
				this.f = (Point)A_0.GetValue("_DestinationNode", typeof(Point));
				this.g = (bool?)A_0.GetValue("_Result", typeof(bool?));
				return;
			}
			this.a = (ar7)A_0.GetValue("CheckInSightAction+_SourceRef", typeof(ar7));
			this.b = (ar7)A_0.GetValue("CheckInSightAction+_EntityTargetRef", typeof(ar7));
			this.c = (edx)A_0.GetValue("CheckInSightAction+_TileTargetRef", typeof(edx));
			this.d = A_0.GetSingle("CheckInSightAction+_Range");
			this.e = (e6z)A_0.GetValue("CheckInSightAction+_DestinationAreaRef", typeof(e6z));
			this.f = (Point)A_0.GetValue("CheckInSightAction+_DestinationNode", typeof(Point));
			this.g = (bool?)A_0.GetValue("CheckInSightAction+_Result", typeof(bool?));
		}
	}

	// Token: 0x06006F42 RID: 28482 RVA: 0x002EB7D0 File Offset: 0x002E99D0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CISA:SR", this.a);
		info.AddValue("CISA:ETR", this.b);
		info.AddValue("CISA:TTR", this.c);
		info.AddValue("CISA:R", this.d);
		info.AddValue("CISA:DAR", this.e);
		info.AddValue("CISA:DN", this.f);
		info.AddValue("CISA:R1", this.g);
		di7.WriteList<byte>("CISA:AO", this.h, info);
	}

	// Token: 0x06006F43 RID: 28483 RVA: 0x002EB878 File Offset: 0x002E9A78
	private b0b e()
	{
		return this.a.ao();
	}

	// Token: 0x06006F44 RID: 28484 RVA: 0x002EB888 File Offset: 0x002E9A88
	private b0b d()
	{
		if (this.b != null)
		{
			return this.b.ao();
		}
		return null;
	}

	// Token: 0x06006F45 RID: 28485 RVA: 0x002EB8A4 File Offset: 0x002E9AA4
	private ak1 c()
	{
		if (this.c != null)
		{
			return this.c.ao();
		}
		return null;
	}

	// Token: 0x06006F46 RID: 28486 RVA: 0x002EB8C0 File Offset: 0x002E9AC0
	private aud b()
	{
		return this.e.ao();
	}

	// Token: 0x06006F47 RID: 28487 RVA: 0x002EB8D0 File Offset: 0x002E9AD0
	public List<byte> f()
	{
		return this.h;
	}

	// Token: 0x06006F48 RID: 28488 RVA: 0x002EB8D8 File Offset: 0x002E9AD8
	public void a(List<byte> A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06006F49 RID: 28489 RVA: 0x002EB8E4 File Offset: 0x002E9AE4
	public dsr(b0b A_0, object A_1, float A_2)
	{
		czh.a(A_0, "source");
		this.a = new ar7(A_0);
		this.d = A_2;
		ak1 ak = A_1 as ak1;
		if (ak != null)
		{
			this.c = new edx(ak);
			return;
		}
		this.b = new ar7((b0b)A_1);
	}

	// Token: 0x06006F4A RID: 28490 RVA: 0x002EB94C File Offset: 0x002E9B4C
	protected override dc4 dt()
	{
		this.g = null;
		if (!this.a())
		{
			return dc4.e;
		}
		anp anp = aw1.b(this.f, this.b(), this.d, bcj.a(this.h), 0L);
		anp.a(new EventHandler<EventArgs>(this.a));
		anp.k();
		return dc4.b;
	}

	// Token: 0x06006F4B RID: 28491 RVA: 0x002EB9B0 File Offset: 0x002E9BB0
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.g == null)
		{
			return dc4.b;
		}
		if (!this.g.Value)
		{
			return dc4.e;
		}
		return dc4.c;
	}

	// Token: 0x06006F4C RID: 28492 RVA: 0x002EB9DC File Offset: 0x002E9BDC
	private bool a()
	{
		if (this.c() != null)
		{
			this.e = new e6z(this.c().Area);
			this.f = this.c().Location;
		}
		else if (this.d() != null)
		{
			if (this.d().j == cgy.a || this.d().Area == null || this.d().l.Count == 0)
			{
				return false;
			}
			this.e = new e6z(this.d().Area);
			this.f = this.d().aj().a();
		}
		return true;
	}

	// Token: 0x06006F4D RID: 28493 RVA: 0x002EBA90 File Offset: 0x002E9C90
	[dcc("CISA:mIF")]
	private void a(object A_0, EventArgs A_1)
	{
		anp anp = A_0 as anp;
		bool value = false;
		if (this.e() != null)
		{
			foreach (ak1 ak in this.e().l)
			{
				if (anp.f().Contains(ak.Location))
				{
					value = true;
					break;
				}
			}
		}
		this.g = new bool?(value);
	}

	// Token: 0x04002D7E RID: 11646
	private new ar7 a;

	// Token: 0x04002D7F RID: 11647
	private ar7 b;

	// Token: 0x04002D80 RID: 11648
	private edx c;

	// Token: 0x04002D81 RID: 11649
	private float d;

	// Token: 0x04002D82 RID: 11650
	private e6z e;

	// Token: 0x04002D83 RID: 11651
	private Point f;

	// Token: 0x04002D84 RID: 11652
	private bool? g;

	// Token: 0x04002D85 RID: 11653
	private List<byte> h = new List<byte>();
}
