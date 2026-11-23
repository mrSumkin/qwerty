using System;
using System.Drawing;
using TimelapseVertigo.Common.Settings;

// Token: 0x020004B0 RID: 1200
public sealed class egd
{
	// Token: 0x06001E77 RID: 7799 RVA: 0x000A9A10 File Offset: 0x000A7C10
	public egd(DisplayResolution A_0, int A_1, int A_2, UiSize A_3, UiSize A_4, InterfaceElementSize2 A_5 = InterfaceElementSize2.Small, float A_6 = 1f)
	{
		this.d = A_0;
		this.a = A_1;
		this.b = A_2;
		this.f = A_3;
		this.g = A_4;
		this.c = A_5;
		this.h = A_6;
		int num = egd.a(this.a, this.b);
		this.e = new Point(A_1 / num, this.b / num);
		if (this.e.X == 8 && this.e.Y == 5)
		{
			this.e = new Point(16, 10);
		}
	}

	// Token: 0x06001E78 RID: 7800 RVA: 0x000A9AB4 File Offset: 0x000A7CB4
	public override string ToString()
	{
		if (this.e.X > 20)
		{
			return string.Format("{0} x {1}", this.a, this.b);
		}
		return string.Format("{0} x {1} ({2}:{3})", new object[]
		{
			this.a,
			this.b,
			this.e.X,
			this.e.Y
		});
	}

	// Token: 0x06001E79 RID: 7801 RVA: 0x000A9B48 File Offset: 0x000A7D48
	public override bool Equals(object obj)
	{
		egd egd = obj as egd;
		return egd != null && egd.d == this.d;
	}

	// Token: 0x06001E7A RID: 7802 RVA: 0x000A9B74 File Offset: 0x000A7D74
	public override int GetHashCode()
	{
		return this.d.GetHashCode();
	}

	// Token: 0x06001E7B RID: 7803 RVA: 0x000A9B88 File Offset: 0x000A7D88
	private static int a(int A_0, int A_1)
	{
		if (A_1 != 0)
		{
			return egd.a(A_1, A_0 % A_1);
		}
		return A_0;
	}

	// Token: 0x0400136A RID: 4970
	public int a;

	// Token: 0x0400136B RID: 4971
	public int b;

	// Token: 0x0400136C RID: 4972
	public InterfaceElementSize2 c;

	// Token: 0x0400136D RID: 4973
	public DisplayResolution d;

	// Token: 0x0400136E RID: 4974
	public Point e;

	// Token: 0x0400136F RID: 4975
	public UiSize f;

	// Token: 0x04001370 RID: 4976
	public UiSize g;

	// Token: 0x04001371 RID: 4977
	public float h;
}
