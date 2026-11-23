using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Items;

// Token: 0x0200143E RID: 5182
[eiz("SA3")]
[Serializable]
public sealed class a13 : c2e, ISerializable
{
	// Token: 0x06007473 RID: 29811 RVA: 0x00316528 File Offset: 0x00314728
	private a13(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("SA3:O");
	}

	// Token: 0x06007474 RID: 29812 RVA: 0x00316544 File Offset: 0x00314744
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SA3:O", this.a);
	}

	// Token: 0x06007475 RID: 29813 RVA: 0x00316560 File Offset: 0x00314760
	public override int? tm()
	{
		if (this.a)
		{
			return new int?(0);
		}
		return base.tm();
	}

	// Token: 0x06007476 RID: 29814 RVA: 0x0031657C File Offset: 0x0031477C
	public a13(amc A_0, amc A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007477 RID: 29815 RVA: 0x00316588 File Offset: 0x00314788
	protected override bool tn()
	{
		if (base.tn())
		{
			return true;
		}
		if (this.a)
		{
			return true;
		}
		cd1 cd = base.n().aa().Offense.u();
		bke bke = cd.TypedDefinition;
		ay7 ay = null;
		dkf dkf = null;
		if (cd != null && !string.IsNullOrEmpty(bke.b()))
		{
			ay = ckf.a(bke.b());
			dkf = (ay as dkf);
		}
		AmmoType ammoType = cd.CurrentBullet;
		if ((dkf == null || !dkf.pa()) && !awq.a(base.n(), cd))
		{
			this.a = true;
			return false;
		}
		if (bke != null && base.m().a8().j == cgy.b && base.m().a8().Area == base.n().a8().Area)
		{
			if (bke.al())
			{
				int num = cd.CustomProperties.GetPrimitivePropertyValue<int>("FirePhase", new int?(1)).Value + 1;
				if (num > 2)
				{
					num = 1;
				}
				cd.CustomProperties["FirePhase"] = num;
			}
			double a_ = aw1.b(base.n().a8(), base.m().a8());
			cwt cwt = this.a(a_, cd, ammoType);
			if (ay != null)
			{
				ay.pe(base.n(), base.m(), cd, cwt, ammoType, null, null);
				if (dkf != null)
				{
					this.b += (double)dkf.pd();
				}
			}
			else
			{
				awq.a(base.n(), base.m(), cwt, cd, null, true, null, null, null, false, false, true, null, null);
			}
			return false;
		}
		return true;
	}

	// Token: 0x06007478 RID: 29816 RVA: 0x00316750 File Offset: 0x00314950
	protected override int to()
	{
		return dz6.b(base.n().aa().Offense.u().TypedDefinition.o().GetValueOrDefault(200));
	}

	// Token: 0x06007479 RID: 29817 RVA: 0x00316790 File Offset: 0x00314990
	protected override CharacterState tp()
	{
		if (base.n() != null && !string.IsNullOrEmpty(base.n().aa().Offense.u().TypedDefinition.b()))
		{
			dkf dkf = ckf.a(base.n().aa().Offense.u().TypedDefinition.b()) as dkf;
			if (dkf != null && dkf.pf(base.n()))
			{
				return CharacterState.Idle;
			}
		}
		cd1 cd = base.n().aa().Offense.u();
		bke bke = cd.TypedDefinition;
		if (bke != null)
		{
			CharacterState result;
			if (bke.al())
			{
				if (cd.CustomProperties.GetPrimitivePropertyValue<int>("FirePhase", new int?(1)).Value == 1)
				{
					return CharacterState.Attack1;
				}
				return CharacterState.Attack2;
			}
			else if (!string.IsNullOrWhiteSpace(bke.ag()) && Enum.TryParse<CharacterState>(bke.ag(), out result))
			{
				return result;
			}
		}
		return CharacterState.Attack1;
	}

	// Token: 0x0600747A RID: 29818 RVA: 0x00316894 File Offset: 0x00314A94
	private cwt a(double A_0, cd1 A_1, AmmoType A_2)
	{
		return euf.a(base.n().aa(), base.m().aa(), A_0, awq.a(base.n(), base.m(), null, null), 0.0, base.m().a8().l(), base.n().aa().Darkvision, A_2, awq.f(base.n()), 1.0, false, null, null, true, null);
	}

	// Token: 0x04002F97 RID: 12183
	private new bool a;
}
