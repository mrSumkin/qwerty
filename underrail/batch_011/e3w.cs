using System;
using System.Collections.Generic;

// Token: 0x0200169C RID: 5788
public abstract class e3w : eqz
{
	// Token: 0x06007E5B RID: 32347 RVA: 0x003580E0 File Offset: 0x003562E0
	protected virtual string b()
	{
		return "thinGrenade";
	}

	// Token: 0x06007E5C RID: 32348 RVA: 0x003580E8 File Offset: 0x003562E8
	protected virtual string a()
	{
		return "ActiveGasGrenade";
	}

	// Token: 0x06007E5D RID: 32349
	protected abstract string aqr();

	// Token: 0x06007E5E RID: 32350
	protected abstract int aqs();

	// Token: 0x06007E5F RID: 32351 RVA: 0x003580F4 File Offset: 0x003562F4
	public sealed override afq ba()
	{
		return new cfi(this.b(), this.a(), this.aqr(), this.aqs());
	}

	// Token: 0x06007E60 RID: 32352 RVA: 0x00358120 File Offset: 0x00356320
	public override List<byte> sb()
	{
		return new List<byte>
		{
			5
		};
	}

	// Token: 0x06007E61 RID: 32353 RVA: 0x00358130 File Offset: 0x00356330
	public override string sc(c5x A_0, eu7 A_1)
	{
		if (A_1.b8().Offense.u().TypedDefinition.a5() == "wheeledBot1Gun")
		{
			return "WheeledBot1CannonShoot";
		}
		return "GrenadeThrow";
	}

	// Token: 0x06007E62 RID: 32354 RVA: 0x00358174 File Offset: 0x00356374
	public override string sd(c5x A_0, eu7 A_1)
	{
		if (A_1.b8().Offense.u().TypedDefinition.a5() == "wheeledBot1Gun")
		{
			return "WheeledBot1CannonLift";
		}
		return "GrenadePinRemove";
	}
}
