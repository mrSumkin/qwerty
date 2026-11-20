using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using TimelapseVertigo.Rules;

// Token: 0x020005B9 RID: 1465
public sealed class hb : ae1
{
	// Token: 0x0600270F RID: 9999 RVA: 0x000E35D4 File Offset: 0x000E17D4
	public override string gr()
	{
		return "param";
	}

	// Token: 0x06002710 RID: 10000 RVA: 0x000E35DC File Offset: 0x000E17DC
	public override object gs(string A_0)
	{
		if (string.IsNullOrEmpty(A_0))
		{
			return null;
		}
		FieldInfo field = typeof(GameDifficultySettings).GetField(A_0);
		if (field != null && Enumerable.FirstOrDefault<object>(field.GetCustomAttributes(typeof(do2), false)) is do2)
		{
			return field;
		}
		return null;
	}

	// Token: 0x06002711 RID: 10001 RVA: 0x000E3638 File Offset: 0x000E1838
	protected override List<object> gt()
	{
		List<object> list = new List<object>();
		foreach (FieldInfo fieldInfo in typeof(GameDifficultySettings).GetFields(BindingFlags.Instance | BindingFlags.Public))
		{
			if (Enumerable.FirstOrDefault<object>(fieldInfo.GetCustomAttributes(typeof(do2), false)) is do2)
			{
				list.Add(fieldInfo.Name);
			}
		}
		return list;
	}
}
