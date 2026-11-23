using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000F4E RID: 3918
[eiz("PHOWFC")]
[Serializable]
public sealed class bfp : dnh, ISerializable
{
	// Token: 0x06004F41 RID: 20289 RVA: 0x0023C358 File Offset: 0x0023A558
	private bfp(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("PHOWFC:RI");
		this.b = A_0.GetBoolean("PHOWFC:I");
	}

	// Token: 0x06004F42 RID: 20290 RVA: 0x0023C384 File Offset: 0x0023A584
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PHOWFC:RI", this.a);
		info.AddValue("PHOWFC:I", this.b);
	}

	// Token: 0x06004F43 RID: 20291 RVA: 0x0023C3B0 File Offset: 0x0023A5B0
	public bool c()
	{
		return this.a;
	}

	// Token: 0x06004F44 RID: 20292 RVA: 0x0023C3B8 File Offset: 0x0023A5B8
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004F45 RID: 20293 RVA: 0x0023C3C4 File Offset: 0x0023A5C4
	public bool b()
	{
		return this.b;
	}

	// Token: 0x06004F46 RID: 20294 RVA: 0x0023C3CC File Offset: 0x0023A5CC
	public void b(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06004F47 RID: 20295 RVA: 0x0023C3D8 File Offset: 0x0023A5D8
	public bfp()
	{
	}

	// Token: 0x06004F48 RID: 20296 RVA: 0x0023C3E4 File Offset: 0x0023A5E4
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		bool flag = false;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqw() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x.h.b != null)
			{
				List<string> list = sg.a;
				if (this.a)
				{
					foreach (string str in sg.a)
					{
						list.Add(str + "_rf");
					}
				}
				foreach (string a_ in list)
				{
					if (c5x.h.b.aa().a(a_, true) != null)
					{
						flag = true;
						break;
					}
				}
			}
		}
		return flag ^ this.b;
	}

	// Token: 0x06004F49 RID: 20297 RVA: 0x0023C504 File Offset: 0x0023A704
	public string a()
	{
		return "PlayerHasOldWorldFirearmCondition";
	}

	// Token: 0x04002082 RID: 8322
	private bool a;

	// Token: 0x04002083 RID: 8323
	private bool b;
}
