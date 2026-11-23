using System;
using System.Linq;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02001895 RID: 6293
[eiz("EAA")]
[Serializable]
public abstract class dyh : c1s, ISerializable
{
	// Token: 0x06008580 RID: 34176 RVA: 0x0037675C File Offset: 0x0037495C
	protected dyh(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (ar7)A_0.GetValue("EAA:SS", typeof(ar7));
		this.b = (bhp)A_0.GetValue("EAA:SB", typeof(bhp));
		this.c = (ActionReference<auv>)A_0.GetValue("EAA:A", typeof(ActionReference<auv>));
		this.d = (atp)A_0.GetValue("EAA:E", typeof(atp));
	}

	// Token: 0x06008581 RID: 34177 RVA: 0x003767FC File Offset: 0x003749FC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("EAA:SS", this.a);
		info.AddValue("EAA:SB", this.b);
		info.AddValue("EAA:A", this.c);
		info.AddValue("EAA:E", this.d);
	}

	// Token: 0x06008582 RID: 34178 RVA: 0x0037685C File Offset: 0x00374A5C
	public bhp h()
	{
		return this.b;
	}

	// Token: 0x06008583 RID: 34179 RVA: 0x00376864 File Offset: 0x00374A64
	public void a(bhp A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06008584 RID: 34180 RVA: 0x00376870 File Offset: 0x00374A70
	public ar7 g()
	{
		if (!ai.b() && this.b != null && this.b.ao7())
		{
			return this.b.GetValue<ar7>(this);
		}
		return this.a;
	}

	// Token: 0x06008585 RID: 34181 RVA: 0x003768AC File Offset: 0x00374AAC
	public void a(ar7 A_0)
	{
		if (!ai.b() && this.b != null && this.b.ao7())
		{
			this.b.SetValue<ar7>(this, A_0);
		}
		this.a = A_0;
	}

	// Token: 0x06008586 RID: 34182 RVA: 0x003768E8 File Offset: 0x00374AE8
	public override TimeSpan ks()
	{
		return TimeSpan.FromMinutes(5.0);
	}

	// Token: 0x06008587 RID: 34183 RVA: 0x003768F8 File Offset: 0x00374AF8
	public atp f()
	{
		return this.d;
	}

	// Token: 0x06008588 RID: 34184 RVA: 0x00376900 File Offset: 0x00374B00
	public void a(atp A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06008589 RID: 34185 RVA: 0x0037690C File Offset: 0x00374B0C
	public dyh()
	{
	}

	// Token: 0x0600858A RID: 34186 RVA: 0x00376920 File Offset: 0x00374B20
	protected override bool b4(e6d A_0)
	{
		base.b4(A_0);
		return this.a();
	}

	// Token: 0x0600858B RID: 34187 RVA: 0x00376930 File Offset: 0x00374B30
	protected override bool aen(e6d A_0)
	{
		if (base.aen(A_0))
		{
			return true;
		}
		if (this.c == null || this.c.ao() == null)
		{
			return this.a();
		}
		dc4 dc = this.c.ao().State;
		return dc == dc4.e || dc == dc4.c || dc == dc4.d;
	}

	// Token: 0x0600858C RID: 34188
	protected abstract auv wy();

	// Token: 0x0600858D RID: 34189 RVA: 0x0037699C File Offset: 0x00374B9C
	protected override void kt(TimeSpan A_0)
	{
		base.kt(A_0);
	}

	// Token: 0x0600858E RID: 34190 RVA: 0x003769A8 File Offset: 0x00374BA8
	protected override void aep(e6d A_0)
	{
		if (this.c != null && this.c.ao() != null && this.c.ao().State == dc4.b)
		{
			this.c.ao().j();
		}
		this.c = null;
	}

	// Token: 0x0600858F RID: 34191 RVA: 0x00376A00 File Offset: 0x00374C00
	private bool a()
	{
		auv auv = this.wy();
		if (auv != null)
		{
			if (this.g() != null)
			{
				cst cst = auv as cst;
				c5x c5x = this.g().ao() as c5x;
				if (c5x != null && c5x.i.b != null && cst != null)
				{
					if (c5x.Zone == null)
					{
						return true;
					}
					c5x.i.b.b(cst, this.d);
					this.c = new ActionReference<auv>(auv);
					return false;
				}
			}
			c1a c1a;
			if (this.g() != null && this.g().ao() != null && this.g().ao().Zone != null)
			{
				c1a = this.g().ao().Zone;
			}
			else
			{
				c1a = Enumerable.FirstOrDefault<c1a>(bpo.GetServiceOrThrow<b4b>().yn().Zones);
			}
			if (c1a != null)
			{
				c1a.ActionManager.g9(auv, this.d);
				this.c = new ActionReference<auv>(auv);
				return false;
			}
		}
		return true;
	}

	// Token: 0x04003324 RID: 13092
	private ar7 a;

	// Token: 0x04003325 RID: 13093
	private bhp b = new bhp();

	// Token: 0x04003326 RID: 13094
	private ActionReference<auv> c;

	// Token: 0x04003327 RID: 13095
	private new atp d;
}
