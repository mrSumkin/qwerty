using System;
using System.IO;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000491 RID: 1169
public static class w3
{
	// Token: 0x06001DEE RID: 7662 RVA: 0x000A5F64 File Offset: 0x000A4164
	public static void a(string A_0)
	{
		cne serviceOrThrow = bpo.GetServiceOrThrow<cne>();
		string[] files = Directory.GetFiles(A_0, "*.xnb", 1);
		int num = A_0.LastIndexOf("\\Data\\");
		string path = A_0.Substring(num + 6);
		foreach (string path2 in files)
		{
			string assetName = Path.Combine(path, Path.Combine(Path.GetDirectoryName(path2), Path.GetFileNameWithoutExtension(path2)).Substring(A_0.Length).TrimStart(new char[]
			{
				'\\'
			}));
			serviceOrThrow.GetResource<Texture2D>(assetName, new double?((double)-1));
		}
	}
}
