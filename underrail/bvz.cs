using System;
using System.Runtime.Serialization;

// Token: 0x02000111 RID: 273
[eiz("EPA")]
[Serializable]
public sealed class bvz : btm, ISerializable
{
	// Token: 0x06000680 RID: 1664 RVA: 0x0001BACC File Offset: 0x00019CCC
	private bvz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() == 0)
		{
			base.GetType() == typeof(bvz);
		}
	}

	// Token: 0x06000681 RID: 1665 RVA: 0x0001BAF8 File Offset: 0x00019CF8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06000682 RID: 1666 RVA: 0x0001BB04 File Offset: 0x00019D04
	protected override bool b4(e6d A_0)
	{
		bpo.GetServiceOrThrow<bbp>().Exit();
		return true;
	}

	// Token: 0x06000683 RID: 1667 RVA: 0x0001BB14 File Offset: 0x00019D14
	public bvz() : base(null)
	{
	}
}
