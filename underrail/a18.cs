using System;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001789 RID: 6025
[z1("slackjaw")]
internal sealed class a18 : c1f
{
	// Token: 0x06008137 RID: 33079 RVA: 0x003679F0 File Offset: 0x00365BF0
	public override void ft(out d3e[] A_0, out wq[] A_1, out string A_2)
	{
		A_0 = new d3e[]
		{
			new ax6(BaseAbilityEnum.Strength.ToString(), 1),
			new ax6(BaseAbilityEnum.Constitution.ToString(), 1),
			new ax6(BaseAbilityEnum.Intelligence.ToString(), -3),
			new ax6(BaseAbilityEnum.Will.ToString(), -1),
			new dpw(SkillEnum.Intimidation.ToString(), 15)
		};
		A_1 = null;
		A_2 = null;
	}
}
