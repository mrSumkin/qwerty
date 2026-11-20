using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Core.Logging;

// Token: 0x02000152 RID: 338
[eiz("COC")]
[Serializable]
public class cq2 : cma, ISerializable
{
	// Token: 0x0600085F RID: 2143 RVA: 0x00023314 File Offset: 0x00021514
	protected cq2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() == 0)
		{
			base.GetType() == typeof(cq2);
		}
	}

	// Token: 0x06000860 RID: 2144 RVA: 0x00023340 File Offset: 0x00021540
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06000861 RID: 2145 RVA: 0x0002334C File Offset: 0x0002154C
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		bool flag = false;
		if (base.a().Count > 0)
		{
			using (List<dnh>.Enumerator enumerator = base.a().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					dnh dnh = enumerator.Current;
					try
					{
						flag = (flag || dnh.cw(A_0, A_1));
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
					if (flag)
					{
						break;
					}
				}
				return flag;
			}
		}
		flag = true;
		return flag;
	}

	// Token: 0x06000862 RID: 2146 RVA: 0x00023440 File Offset: 0x00021640
	public override string ToString()
	{
		return "OR";
	}

	// Token: 0x06000863 RID: 2147 RVA: 0x00023448 File Offset: 0x00021648
	public cq2()
	{
	}
}
