using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020017CD RID: 6093
internal class rf : ak9
{
	// Token: 0x060081F2 RID: 33266 RVA: 0x0036B4D4 File Offset: 0x003696D4
	public override void ft(out d3e[] A_0, out wq[] A_1, out string A_2)
	{
		List<BaseAbilityEnum> list = new List<BaseAbilityEnum>();
		list.Add(BaseAbilityEnum.Strength);
		list.Add(BaseAbilityEnum.Dexterity);
		list.Add(BaseAbilityEnum.Agility);
		list.Add(BaseAbilityEnum.Constitution);
		List<BaseAbilityEnum> list2 = new List<BaseAbilityEnum>();
		list2.Add(BaseAbilityEnum.Strength);
		list2.Add(BaseAbilityEnum.Dexterity);
		list2.Add(BaseAbilityEnum.Agility);
		list2.Add(BaseAbilityEnum.Constitution);
		list2.Add(BaseAbilityEnum.Perception);
		list2.Add(BaseAbilityEnum.Will);
		list2.Add(BaseAbilityEnum.Intelligence);
		string text = list[cuo.a.Next(list.Count)].ToString();
		string text2 = list2[cuo.a.Next(list2.Count)].ToString();
		if (text == text2)
		{
			A_0 = new d3e[]
			{
				new ax6(text, 1)
			};
			A_2 = string.Format("{0} - увеличено на 1.", text);
		}
		else
		{
			int num = 1 + cuo.a.Next(2);
			int num2 = 1 + cuo.a.Next(2);
			A_0 = new d3e[]
			{
				new ax6(text, num),
				new ax6(text2, -num2)
			};
			A_2 = string.Format("{0} - увеличено на {1}. {2} - уменьшено на {3}.", new object[]
			{
				text,
				num,
				text2,
				num2
			});
		}
		A_1 = null;
	}
}
