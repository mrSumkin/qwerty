using System;
using Microsoft.Xna.Framework.Content;

// Token: 0x0200012B RID: 299
public class ewl : ContentManager
{
	// Token: 0x0600071F RID: 1823 RVA: 0x0001CF74 File Offset: 0x0001B174
	public ewl(IServiceProvider A_0, string A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06000720 RID: 1824 RVA: 0x0001CF80 File Offset: 0x0001B180
	public override T Load<T>(string assetName)
	{
		return base.ReadAsset<T>(assetName, null);
	}
}
