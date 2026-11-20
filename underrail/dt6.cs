using System;

// Token: 0x02000472 RID: 1138
public sealed class dt6 : adt
{
	// Token: 0x06001D74 RID: 7540 RVA: 0x000A317C File Offset: 0x000A137C
	public dt6(string A_0, string A_1, Action<dt6> A_2 = null) : base(A_0)
	{
		this.a = A_1;
		this.b = A_2;
	}

	// Token: 0x06001D75 RID: 7541 RVA: 0x000A3194 File Offset: 0x000A1394
	public override ej1 aci(TimeSpan A_0, double A_1)
	{
		TimeSpan? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<TimeSpan>(this.a, null);
		if (primitivePropertyValue == null)
		{
			return ej1.c;
		}
		primitivePropertyValue = new TimeSpan?(primitivePropertyValue.Value.Subtract(TimeSpan.FromMilliseconds(A_1)));
		if (primitivePropertyValue <= TimeSpan.Zero)
		{
			this.Subject.y6()[this.a] = TimeSpan.Zero;
			if (this.b != null)
			{
				this.b(this);
			}
			return ej1.b;
		}
		this.Subject.y6()[this.a] = primitivePropertyValue;
		return ej1.a;
	}

	// Token: 0x06001D76 RID: 7542 RVA: 0x000A3270 File Offset: 0x000A1470
	public override bool acj(TimeSpan A_0, double A_1)
	{
		return true;
	}

	// Token: 0x04001040 RID: 4160
	private string a;

	// Token: 0x04001041 RID: 4161
	private new Action<dt6> b;
}
