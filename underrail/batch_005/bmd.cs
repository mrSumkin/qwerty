using System;
using TimelapseVertigo.Generators.Items;

// Token: 0x02000716 RID: 1814
public sealed class bmd
{
	// Token: 0x17000182 RID: 386
	// (get) Token: 0x06002F0E RID: 12046 RVA: 0x0011DE1C File Offset: 0x0011C01C
	public coh Item
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x17000183 RID: 387
	// (get) Token: 0x06002F0F RID: 12047 RVA: 0x0011DE24 File Offset: 0x0011C024
	public AutoEquipMode AutoEquipMode
	{
		get
		{
			return this.b;
		}
	}

	// Token: 0x06002F10 RID: 12048 RVA: 0x0011DE2C File Offset: 0x0011C02C
	public bmd(coh A_0, AutoEquipMode A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x04001A1A RID: 6682
	private coh a;

	// Token: 0x04001A1B RID: 6683
	private AutoEquipMode b;
}
