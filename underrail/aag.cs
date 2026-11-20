using System;
using System.Runtime.Serialization;
using Ouroboros.Core.Logging;

// Token: 0x02000150 RID: 336
[eiz("CAC")]
[Serializable]
public class aag : cma, ISerializable
{
	// Token: 0x06000854 RID: 2132 RVA: 0x00023040 File Offset: 0x00021240
	protected aag(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() == 0)
		{
			base.GetType() == typeof(aag);
		}
	}

	// Token: 0x06000855 RID: 2133 RVA: 0x0002306C File Offset: 0x0002126C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06000856 RID: 2134 RVA: 0x00023078 File Offset: 0x00021278
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		bool flag = true;
		if (base.a().Count > 0)
		{
			foreach (dnh dnh in base.a())
			{
				try
				{
					flag = (flag && dnh.cw(A_0, A_1));
				}
				catch (Exception ex)
				{
					cvq service = bpo.GetService<cvq>();
					if (service != null && service.n8() && service.n9(LogSeverity.Error, 115))
					{
						string a_ = string.Format("[Dialog Manager] - Error occurred while evaluation condition '{0}'. Exception: {1}", dnh.h(), ex.ToString());
						service.n7(LogSeverity.Error, 115, a_);
					}
					flag = false;
				}
				if (!flag)
				{
					break;
				}
			}
		}
		return flag;
	}

	// Token: 0x06000857 RID: 2135 RVA: 0x00023168 File Offset: 0x00021368
	public override string ToString()
	{
		return "AND";
	}

	// Token: 0x06000858 RID: 2136 RVA: 0x00023170 File Offset: 0x00021370
	public aag()
	{
	}
}
