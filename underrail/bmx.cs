using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

// Token: 0x020005EC RID: 1516
[eiz("SADCWDLC")]
[Serializable]
public sealed class bmx : dth, ISerializable
{
	// Token: 0x060027CC RID: 10188 RVA: 0x000E6D54 File Offset: 0x000E4F54
	private bmx(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (A_0.GetValue("SADCWDLC:C", typeof(dnh)) as dnh);
		this.b = A_0.GetString("SADCWDLC:DLC");
	}

	// Token: 0x060027CD RID: 10189 RVA: 0x000E6D90 File Offset: 0x000E4F90
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("SADC:C", this.a);
		info.AddValue("SADCWDLC:DLC", this.b);
	}

	// Token: 0x060027CE RID: 10190 RVA: 0x000E6DB4 File Offset: 0x000E4FB4
	public bmx()
	{
	}

	// Token: 0x060027CF RID: 10191 RVA: 0x000E6DC0 File Offset: 0x000E4FC0
	public bool jh(object A_0)
	{
		if (!string.IsNullOrEmpty(this.b) && !dk2.b(this.b))
		{
			return false;
		}
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

	// Token: 0x060027D0 RID: 10192 RVA: 0x000E6E2C File Offset: 0x000E502C
	public string ji()
	{
		return null;
	}

	// Token: 0x04001642 RID: 5698
	private dnh a;

	// Token: 0x04001643 RID: 5699
	private string b;
}
