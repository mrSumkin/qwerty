using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Comm;

// Token: 0x02001699 RID: 5785
public abstract class as9 : eqz
{
	// Token: 0x06007E42 RID: 32322 RVA: 0x00357EE4 File Offset: 0x003560E4
	protected virtual string hq()
	{
		return "grenade";
	}

	// Token: 0x06007E43 RID: 32323
	protected abstract CombatSpeakEvent[] hr();

	// Token: 0x06007E44 RID: 32324 RVA: 0x00357EEC File Offset: 0x003560EC
	protected virtual bool apd()
	{
		return false;
	}

	// Token: 0x06007E45 RID: 32325 RVA: 0x00357EF0 File Offset: 0x003560F0
	public sealed override afq ba()
	{
		return new cqu(this.hq(), this.ht(), this.hv(), this.hu(), this.hw(), this.w0(), this.hr(), this.hs(), this.apd());
	}

	// Token: 0x06007E46 RID: 32326 RVA: 0x00357F38 File Offset: 0x00356138
	public override string sa()
	{
		return base.sa();
	}

	// Token: 0x06007E47 RID: 32327 RVA: 0x00357F40 File Offset: 0x00356140
	protected virtual double hs()
	{
		return 0.0;
	}

	// Token: 0x06007E48 RID: 32328
	protected abstract cuu ht();

	// Token: 0x06007E49 RID: 32329 RVA: 0x00357F4C File Offset: 0x0035614C
	protected virtual blv hu()
	{
		return null;
	}

	// Token: 0x06007E4A RID: 32330 RVA: 0x00357F50 File Offset: 0x00356150
	protected virtual int hv()
	{
		return 100;
	}

	// Token: 0x06007E4B RID: 32331 RVA: 0x00357F54 File Offset: 0x00356154
	public override List<byte> sb()
	{
		return new List<byte>
		{
			5
		};
	}

	// Token: 0x06007E4C RID: 32332 RVA: 0x00357F64 File Offset: 0x00356164
	protected virtual string hw()
	{
		return null;
	}

	// Token: 0x06007E4D RID: 32333 RVA: 0x00357F68 File Offset: 0x00356168
	protected virtual string w0()
	{
		return null;
	}

	// Token: 0x06007E4E RID: 32334 RVA: 0x00357F70 File Offset: 0x00356170
	public override string sc(c5x A_0, eu7 A_1)
	{
		if (A_1.b8().Offense.u().TypedDefinition.a5() == "wheeledBot1Gun")
		{
			return "WheeledBot1CannonShoot";
		}
		return "GrenadeThrow";
	}

	// Token: 0x06007E4F RID: 32335 RVA: 0x00357FB4 File Offset: 0x003561B4
	public override string sd(c5x A_0, eu7 A_1)
	{
		if (A_1.b8().Offense.u().TypedDefinition.a5() == "wheeledBot1Gun")
		{
			return "WheeledBot1CannonLift";
		}
		return "GrenadePinRemove";
	}
}
