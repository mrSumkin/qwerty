using System;

// Token: 0x02001923 RID: 6435
public sealed class d5o
{
	// Token: 0x1700020E RID: 526
	// (get) Token: 0x0600889C RID: 34972 RVA: 0x00388388 File Offset: 0x00386588
	public coh Item
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x1700020F RID: 527
	// (get) Token: 0x0600889D RID: 34973 RVA: 0x00388390 File Offset: 0x00386590
	// (set) Token: 0x0600889E RID: 34974 RVA: 0x00388398 File Offset: 0x00386598
	public int StackPortion
	{
		get
		{
			return this.b;
		}
		set
		{
			this.b = value;
		}
	}

	// Token: 0x0600889F RID: 34975 RVA: 0x003883A4 File Offset: 0x003865A4
	public d5o(coh A_0, int A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x04003690 RID: 13968
	private coh a;

	// Token: 0x04003691 RID: 13969
	private int b;
}
