using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

// Token: 0x020005F0 RID: 1520
[eiz("SADC")]
[Serializable]
public sealed class czd : dth, ISerializable
{
	// Token: 0x060027EB RID: 10219 RVA: 0x000E712C File Offset: 0x000E532C
	private czd(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (A_0.GetValue("SADC:C", typeof(dnh)) as dnh);
	}

	// Token: 0x060027EC RID: 10220 RVA: 0x000E7154 File Offset: 0x000E5354
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("SADC:C", this.a);
	}

	// Token: 0x060027ED RID: 10221 RVA: 0x000E7168 File Offset: 0x000E5368
	public czd()
	{
	}

	// Token: 0x060027EE RID: 10222 RVA: 0x000E7174 File Offset: 0x000E5374
	public bool jh(object A_0)
	{
		if (this.a != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				bq8 a_ = serviceOrThrow.aqu().e();
				return this.a.cw(a_, new PropertyCollection());
			}
		}
		return false;
	}

	// Token: 0x060027EF RID: 10223 RVA: 0x000E71BC File Offset: 0x000E53BC
	public string ji()
	{
		if (this.a != null)
		{
			return this.a.ji();
		}
		return null;
	}

	// Token: 0x060027F0 RID: 10224 RVA: 0x000E71D8 File Offset: 0x000E53D8
	public override string ToString()
	{
		return this.ji();
	}

	// Token: 0x04001649 RID: 5705
	public dnh a;
}
