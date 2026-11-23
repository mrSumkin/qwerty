using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001433 RID: 5171
[eiz("AARA")]
[Serializable]
public class akg : azp, ISerializable
{
	// Token: 0x060073EB RID: 29675 RVA: 0x00310BB4 File Offset: 0x0030EDB4
	protected akg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (cwt)A_0.GetValue("AARA:AR", typeof(cwt));
			this.c = (A_0.GetValue("AARA:CB", typeof(enp)) as enp);
			if (ell.a() >= 262)
			{
				this.b = (cru)A_0.GetValue("AARA:S", typeof(cru));
			}
			if (ell.a() >= 514)
			{
				this.d = A_0.GetBoolean("AARA:H");
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(akg))
			{
				this.a = (cwt)A_0.GetValue("_AttackResult", typeof(cwt));
				return;
			}
			this.a = (cwt)A_0.GetValue("ApplyAttackResultAction+_AttackResult", typeof(cwt));
		}
	}

	// Token: 0x060073EC RID: 29676 RVA: 0x00310CC0 File Offset: 0x0030EEC0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("AARA:AR", this.a);
		info.AddValue("AARA:S", this.b);
		info.AddValue("AARA:CB", this.c);
		info.AddValue("AARA:H", this.d);
	}

	// Token: 0x060073ED RID: 29677 RVA: 0x00310D1C File Offset: 0x0030EF1C
	public cwt d()
	{
		return this.a;
	}

	// Token: 0x060073EE RID: 29678 RVA: 0x00310D24 File Offset: 0x0030EF24
	public cru b()
	{
		return this.b;
	}

	// Token: 0x060073EF RID: 29679 RVA: 0x00310D2C File Offset: 0x0030EF2C
	public bool c()
	{
		return this.d;
	}

	// Token: 0x060073F0 RID: 29680 RVA: 0x00310D34 File Offset: 0x0030EF34
	public void a(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060073F1 RID: 29681 RVA: 0x00310D40 File Offset: 0x0030EF40
	public akg(amc A_0, amc A_1, cwt A_2, enp A_3 = null, bool A_4 = false) : base(A_0, A_1)
	{
		czh.a(A_2, "attackResult");
		this.a = A_2;
		this.c = A_3;
		this.d = A_4;
	}

	// Token: 0x060073F2 RID: 29682 RVA: 0x00310D70 File Offset: 0x0030EF70
	protected override dc4 dt()
	{
		if (base.m() == null)
		{
			return dc4.e;
		}
		this.a = this.p7();
		base.m().aa().Defense.q().zo();
		this.b = base.m().aa().Defense.a(this.a);
		int num2;
		if (this.a.a(c3u.d))
		{
			int num = 0;
			if (this.a.i != null && this.a.i.i.ContainsKey("OpportunistDisabledTarget"))
			{
				num = this.a.i.i["OpportunistDisabledTarget"];
			}
			num2 = Convert.ToInt32((zf.a + (double)num * d6q.a) * 100.0);
		}
		else if (this.a.a(c3u.c))
		{
			int num3 = 0;
			if (this.a.i != null && this.a.i.i.ContainsKey("OpportunistSlowedTarget"))
			{
				num3 = this.a.i.i["OpportunistSlowedTarget"];
			}
			num2 = Convert.ToInt32((zf.b + (double)num3 * c70.a) * 100.0);
		}
		else
		{
			num2 = 0;
		}
		if (base.n() != null)
		{
			if (this.a.a(c3u.g))
			{
				bmj.a(base.n().a8(), new cz5(string.Format("Прицеливание по стволу +{0}%", (int)((afn.a + (double)base.n().aa().GetSpecializationValue<b1v>(true) * b1v.a) * 100.0)), Color.DarkOrange, null, false));
			}
			if (this.a.a(c3u.b))
			{
				bmj.a(base.n().a8(), new cz5("Смертоносные ловушки: гарантированное критическое попадание", Color.DarkOrange, null, false));
			}
			if (num2 > 0)
			{
				bmj.a(base.n().a8(), new cz5(string.Format("Оппортунистическая атака +{0}%", num2), Color.DarkOrange, null, false));
			}
			if (this.a.a(c3u.e))
			{
				bmj.a(base.n().a8(), new cz5(string.Format("Засада!", num2), Color.DarkOrange, null, false));
			}
		}
		if (this.c != null)
		{
			this.c.af(base.n(), base.m(), this.a, this.b);
		}
		return dc4.c;
	}

	// Token: 0x060073F3 RID: 29683 RVA: 0x00311018 File Offset: 0x0030F218
	protected virtual cwt p7()
	{
		if (this.d)
		{
			awq.a(base.n(), base.m(), this.a);
		}
		return this.d();
	}

	// Token: 0x060073F4 RID: 29684 RVA: 0x00311044 File Offset: 0x0030F244
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		return dc4.c;
	}

	// Token: 0x04002F64 RID: 12132
	private new cwt a;

	// Token: 0x04002F65 RID: 12133
	private cru b;

	// Token: 0x04002F66 RID: 12134
	private enp c;

	// Token: 0x04002F67 RID: 12135
	private bool d;
}
