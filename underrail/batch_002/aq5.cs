using System;

// Token: 0x02000104 RID: 260
public abstract class aq5 : e6e
{
	// Token: 0x06000631 RID: 1585 RVA: 0x0001AD68 File Offset: 0x00018F68
	protected aq5(int A_0 = 0) : base(A_0)
	{
	}

	// Token: 0x06000632 RID: 1586 RVA: 0x0001AD74 File Offset: 0x00018F74
	protected override void r3(Type A_0)
	{
		if (A_0.IsClass || A_0.IsInterface)
		{
			object[] customAttributes = A_0.GetCustomAttributes(typeof(b3d), false);
			if (customAttributes.Length != 0)
			{
				eh9.a(((b3d)customAttributes[0]).a());
				return;
			}
		}
	}
}
