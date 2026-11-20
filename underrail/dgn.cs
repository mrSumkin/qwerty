using System;
using System.Runtime.Serialization;

// Token: 0x02001932 RID: 6450
[eiz("MI")]
[Serializable]
public class dgn : cv9, ISerializable
{
	// Token: 0x060088E3 RID: 35043 RVA: 0x00388928 File Offset: 0x00386B28
	protected dgn(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(dgn);
		}
	}

	// Token: 0x060088E4 RID: 35044 RVA: 0x00388954 File Offset: 0x00386B54
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x060088E5 RID: 35045 RVA: 0x00388960 File Offset: 0x00386B60
	public override string tv()
	{
		return "Медицинский препарат";
	}

	// Token: 0x060088E6 RID: 35046 RVA: 0x00388968 File Offset: 0x00386B68
	public override bk3 tw()
	{
		dgn dgn = new dgn();
		this.ai7(dgn);
		return dgn;
	}

	// Token: 0x060088E7 RID: 35047 RVA: 0x00388984 File Offset: 0x00386B84
	public dgn()
	{
	}
}
