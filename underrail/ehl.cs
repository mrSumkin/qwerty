using System;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001E65 RID: 7781
public abstract class ehl : c3n
{
	// Token: 0x0600AC6A RID: 44138 RVA: 0x003F9D24 File Offset: 0x003F7F24
	public virtual TimelapseCursor? bj()
	{
		return null;
	}

	// Token: 0x0600AC6B RID: 44139 RVA: 0x003F9D3C File Offset: 0x003F7F3C
	public virtual a3b c0()
	{
		return null;
	}

	// Token: 0x0600AC6C RID: 44140 RVA: 0x003F9D40 File Offset: 0x003F7F40
	public virtual bool vi()
	{
		return false;
	}

	// Token: 0x0600AC6D RID: 44141 RVA: 0x003F9D44 File Offset: 0x003F7F44
	public virtual bool akb()
	{
		return false;
	}

	// Token: 0x0600AC6E RID: 44142 RVA: 0x003F9D48 File Offset: 0x003F7F48
	public virtual bool j7()
	{
		return false;
	}

	// Token: 0x0600AC6F RID: 44143 RVA: 0x003F9D4C File Offset: 0x003F7F4C
	public virtual bool q2()
	{
		return true;
	}

	// Token: 0x0600AC70 RID: 44144 RVA: 0x003F9D50 File Offset: 0x003F7F50
	public virtual TimelapseCursor? wz(object A_0, bool A_1 = false)
	{
		return this.bj();
	}

	// Token: 0x0600AC71 RID: 44145 RVA: 0x003F9D58 File Offset: 0x003F7F58
	public virtual a3b bl(cnm A_0, efk A_1)
	{
		return this.c0();
	}

	// Token: 0x0600AC72 RID: 44146
	public abstract SpellTargetType bn(cnm A_0);

	// Token: 0x0600AC73 RID: 44147 RVA: 0x003F9D60 File Offset: 0x003F7F60
	public virtual float afi(cnm A_0)
	{
		return this.f0(A_0) * this.i(A_0) + this.afj(A_0);
	}

	// Token: 0x0600AC74 RID: 44148 RVA: 0x003F9D7C File Offset: 0x003F7F7C
	public int n(cnm A_0)
	{
		return Convert.ToInt32((float)this.br(A_0) * this.te(A_0));
	}

	// Token: 0x0600AC75 RID: 44149 RVA: 0x003F9D94 File Offset: 0x003F7F94
	public int s(cnm A_0)
	{
		return Convert.ToInt32((float)this.ma(A_0) * this.j(A_0));
	}

	// Token: 0x0600AC76 RID: 44150 RVA: 0x003F9DAC File Offset: 0x003F7FAC
	public int h(cnm A_0)
	{
		return Convert.ToInt32((float)this.mb(A_0) * this.j(A_0));
	}

	// Token: 0x0600AC77 RID: 44151 RVA: 0x003F9DC4 File Offset: 0x003F7FC4
	public int g(cnm A_0)
	{
		return Convert.ToInt32((float)this.d2(A_0) * this.l(A_0));
	}

	// Token: 0x0600AC78 RID: 44152 RVA: 0x003F9DDC File Offset: 0x003F7FDC
	public double m(cnm A_0)
	{
		return this.q3(A_0) * this.k(A_0);
	}

	// Token: 0x0600AC79 RID: 44153 RVA: 0x003F9DF0 File Offset: 0x003F7FF0
	public double q(cnm A_0)
	{
		return this.xe(A_0) * this.p(A_0);
	}

	// Token: 0x0600AC7A RID: 44154 RVA: 0x003F9E04 File Offset: 0x003F8004
	public override bool hm(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().StatusEffects.a(bdm.a))
		{
			return false;
		}
		if (!base.hm(A_0))
		{
			return false;
		}
		if (A_0 != null && A_0.b8() != null)
		{
			if (!this.CanBeUsedWhileDriving && A_0.b8().Vehicle != null)
			{
				return false;
			}
			if (!this.j7() && A_0.b8().StatusEffects.a(ex.a))
			{
				return false;
			}
			if (!this.q2() && A_0.b8().b(d8o.t))
			{
				return false;
			}
		}
		coh coh = A_0.b9() as coh;
		if (coh != null)
		{
			if (A_0.b8() != null && A_0.b8().SpecialStates.f)
			{
				return false;
			}
			if (!coh.anx(A_0.b8()))
			{
				return false;
			}
			if (!this.vi() && coh.Definition != null && !coh.Definition.a9() && coh.MaxDurability > 0 && coh.Durability / (double)coh.MaxDurability < dwh.i)
			{
				return false;
			}
			double num = this.m(A_0);
			if (num > 0.0)
			{
				if (coh.Battery < num)
				{
					return false;
				}
			}
			else
			{
				double num2 = this.q(A_0);
				if (num2 > 0.0)
				{
					return coh.Battery >= num2;
				}
			}
		}
		else if (this.RequiresMedium)
		{
			return false;
		}
		return true;
	}

	// Token: 0x0600AC7B RID: 44155 RVA: 0x003F9FB0 File Offset: 0x003F81B0
	public override bool cu(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().StatusEffects.a(bdm.a))
		{
			return false;
		}
		if (A_0.b8() != null && !A_0.b8().IsInControl)
		{
			return false;
		}
		if (A_0.b8() != null && !this.j7() && A_0.b8().StatusEffects.a(ex.a))
		{
			return false;
		}
		coh coh = A_0.b9() as coh;
		if (coh != null)
		{
			if (A_0.b8() != null && A_0.b8().SpecialStates.f)
			{
				return false;
			}
			if (!coh.anx(A_0.b8()))
			{
				return false;
			}
			double num = this.q(A_0);
			if (num > 0.0)
			{
				return coh.Battery >= num;
			}
		}
		return true;
	}

	// Token: 0x0600AC7C RID: 44156 RVA: 0x003FA0A8 File Offset: 0x003F82A8
	public virtual float r(cnm A_0)
	{
		return 1f;
	}

	// Token: 0x0600AC7D RID: 44157 RVA: 0x003FA0B0 File Offset: 0x003F82B0
	public virtual bna iw(cnm A_0)
	{
		return bna.a;
	}

	// Token: 0x0600AC7E RID: 44158 RVA: 0x003FA0B4 File Offset: 0x003F82B4
	public virtual bool gz(cnm A_0)
	{
		return true;
	}

	// Token: 0x0600AC7F RID: 44159 RVA: 0x003FA0B8 File Offset: 0x003F82B8
	public virtual int zb(eoj A_0)
	{
		return 0;
	}

	// Token: 0x0600AC80 RID: 44160 RVA: 0x003FA0BC File Offset: 0x003F82BC
	protected virtual double q3(cnm A_0)
	{
		return 0.0;
	}

	// Token: 0x0600AC81 RID: 44161 RVA: 0x003FA0C8 File Offset: 0x003F82C8
	protected virtual double k(cnm A_0)
	{
		return 1.0;
	}

	// Token: 0x0600AC82 RID: 44162 RVA: 0x003FA0D4 File Offset: 0x003F82D4
	protected virtual double xe(cnm A_0)
	{
		return 0.0;
	}

	// Token: 0x0600AC83 RID: 44163 RVA: 0x003FA0E0 File Offset: 0x003F82E0
	protected virtual double p(cnm A_0)
	{
		return 1.0;
	}

	// Token: 0x0600AC84 RID: 44164 RVA: 0x003FA0EC File Offset: 0x003F82EC
	protected virtual int br(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0600AC85 RID: 44165 RVA: 0x003FA0F0 File Offset: 0x003F82F0
	protected virtual float te(cnm A_0)
	{
		return 1f;
	}

	// Token: 0x0600AC86 RID: 44166 RVA: 0x003FA0F8 File Offset: 0x003F82F8
	protected virtual int ma(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0600AC87 RID: 44167 RVA: 0x003FA0FC File Offset: 0x003F82FC
	protected virtual float o(cnm A_0)
	{
		return 1f;
	}

	// Token: 0x0600AC88 RID: 44168 RVA: 0x003FA104 File Offset: 0x003F8304
	protected virtual int mb(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0600AC89 RID: 44169 RVA: 0x003FA108 File Offset: 0x003F8308
	protected virtual float j(cnm A_0)
	{
		return 1f;
	}

	// Token: 0x0600AC8A RID: 44170 RVA: 0x003FA110 File Offset: 0x003F8310
	protected virtual int d2(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0600AC8B RID: 44171 RVA: 0x003FA114 File Offset: 0x003F8314
	protected virtual float l(cnm A_0)
	{
		return 1f;
	}

	// Token: 0x0600AC8C RID: 44172 RVA: 0x003FA11C File Offset: 0x003F831C
	protected virtual float f0(cnm A_0)
	{
		return 0f;
	}

	// Token: 0x0600AC8D RID: 44173 RVA: 0x003FA124 File Offset: 0x003F8324
	protected virtual float i(cnm A_0)
	{
		return 1f;
	}

	// Token: 0x0600AC8E RID: 44174 RVA: 0x003FA12C File Offset: 0x003F832C
	protected virtual float afj(cnm A_0)
	{
		return 0f;
	}

	// Token: 0x0600AC8F RID: 44175 RVA: 0x003FA134 File Offset: 0x003F8334
	protected static coh a(cnm A_0)
	{
		if (A_0 != null)
		{
			return A_0.b9() as coh;
		}
		return null;
	}
}
