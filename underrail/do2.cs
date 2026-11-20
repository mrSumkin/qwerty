using System;

// Token: 0x020018BF RID: 6335
[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
public sealed class do2 : Attribute
{
	// Token: 0x0600866D RID: 34413 RVA: 0x0037BB34 File Offset: 0x00379D34
	public do2(float A_0, float A_1, bool A_2 = false)
	{
		this.b = A_0;
		this.c = A_1;
		this.a = A_2;
	}

	// Token: 0x040033BF RID: 13247
	public bool a;

	// Token: 0x040033C0 RID: 13248
	public float b;

	// Token: 0x040033C1 RID: 13249
	public float c;
}
