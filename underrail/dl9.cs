using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

// Token: 0x020005D4 RID: 1492
public sealed class dl9 : ce8
{
	// Token: 0x06002773 RID: 10099 RVA: 0x000E5548 File Offset: 0x000E3748
	public override string[] c6()
	{
		return new string[]
		{
			"exportquests"
		};
	}

	// Token: 0x06002775 RID: 10101 RVA: 0x000E5564 File Offset: 0x000E3764
	public override lu c7(List<object> A_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (KeyValuePair<string, eei> keyValuePair in ao5.a)
		{
			stringBuilder.Append("::");
			stringBuilder.Append(keyValuePair.Key);
			stringBuilder.AppendLine();
			stringBuilder.AppendLine(keyValuePair.Value.DisplayText);
			stringBuilder.AppendLine();
		}
		File.WriteAllText(Path.Combine(bpo.GetServiceOrThrow<d67>().lf(), "Knowledge\\quests.txt"), stringBuilder.ToString());
		return null;
	}
}
