using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x020009A0 RID: 2464
[eiz("LUSRTOBFD")]
[Serializable]
public sealed class dpm : bdw, ISerializable
{
	// Token: 0x06003B7C RID: 15228 RVA: 0x0016022C File Offset: 0x0015E42C
	private dpm(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B7D RID: 15229 RVA: 0x00160234 File Offset: 0x0015E434
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B7E RID: 15230 RVA: 0x00160238 File Offset: 0x0015E438
	public dpm()
	{
	}

	// Token: 0x06003B7F RID: 15231 RVA: 0x00160244 File Offset: 0x0015E444
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("lu-b31");
			if (aud != null && bpo.GetServiceOrThrow<cnk>() != null)
			{
				doq a_ = doq.a(Path.Combine(d5x.q(), "lu-b31_l3") + ".uzl");
				aud.Zone.a(a_, 1, null);
				axh aspect = (new ar7(new Guid("4e910a1d-ea21-4976-ba1c-39363695fd00"), aud).ao() as c5x).GetAspect<axh>();
				if (aspect != null)
				{
					aspect.a(null, false, null);
				}
				c5x c5x = new ar7(new Guid("b69774f2-1c2d-49c4-bfc6-e6b9f65d4888"), aud).ao() as c5x;
				if (c5x != null && c5x.GetAspect<axh>() != null)
				{
					c5x.RemoveAspect<axh>();
				}
			}
		}
	}
}
