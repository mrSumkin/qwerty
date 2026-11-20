using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;

// Token: 0x020012B2 RID: 4786
[eiz("ESEA0")]
[Serializable]
public abstract class bbw : Aspect<c5x>, ISerializable
{
	// Token: 0x06006911 RID: 26897 RVA: 0x002C5AF8 File Offset: 0x002C3CF8
	protected bbw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06006912 RID: 26898
	public abstract int s6();

	// Token: 0x06006913 RID: 26899
	public abstract void s7(int A_0);

	// Token: 0x06006914 RID: 26900
	public abstract double s8();

	// Token: 0x06006915 RID: 26901
	public abstract void s9(double A_0);

	// Token: 0x06006916 RID: 26902 RVA: 0x002C5B04 File Offset: 0x002C3D04
	public virtual Point ta()
	{
		return Point.Zero;
	}

	// Token: 0x06006917 RID: 26903 RVA: 0x002C5B0C File Offset: 0x002C3D0C
	public bbw(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006918 RID: 26904
	public abstract bool tb();

	// Token: 0x06006919 RID: 26905
	public abstract double tc(c5x A_0, double A_1);

	// Token: 0x0600691A RID: 26906
	public abstract double td(c5x A_0, double A_1, bool A_2 = true);
}
