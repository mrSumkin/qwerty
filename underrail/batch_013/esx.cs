using System;
using System.Runtime.Serialization;

// Token: 0x02001E25 RID: 7717
[eiz("DFS")]
[Serializable]
public class esx : an2, ISerializable
{
	// Token: 0x0600AAF3 RID: 43763 RVA: 0x003F538C File Offset: 0x003F358C
	protected esx(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600AAF4 RID: 43764 RVA: 0x003F5398 File Offset: 0x003F3598
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600AAF5 RID: 43765 RVA: 0x003F53A4 File Offset: 0x003F35A4
	public esx()
	{
	}

	// Token: 0x0600AAF6 RID: 43766 RVA: 0x003F53AC File Offset: 0x003F35AC
	public esx(efk A_0) : base(A_0)
	{
	}
}
