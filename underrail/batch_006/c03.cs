using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;

// Token: 0x02000AC1 RID: 2753
[eiz("XPBLULGM")]
[Serializable]
public sealed class c03 : cze, ISerializable
{
	// Token: 0x06004030 RID: 16432 RVA: 0x00185F54 File Offset: 0x00184154
	private c03(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004031 RID: 16433 RVA: 0x00185F60 File Offset: 0x00184160
	public c03()
	{
	}

	// Token: 0x06004032 RID: 16434 RVA: 0x00185F6C File Offset: 0x0018416C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null && serviceOrThrow.aqu().v() != null && (serviceOrThrow.aqu().v().b() != null & serviceOrThrow.aqu().v().b().Area != null))
		{
			cd0 cd;
			cd0 cd2;
			cd0 cd3;
			if (serviceOrThrow.aqu().v().b().Area.y8() == "xpbl_c3")
			{
				cd = new EntityAspectReference<cd0, cd0>(serviceOrThrow.aqu().v().b().Area, new Guid("71f96c69-468d-440c-b579-825e4f685ba2")).ao();
				cd2 = new EntityAspectReference<cd0, cd0>(serviceOrThrow.aqu().v().b().Area, new Guid("e6bab814-ad86-4707-a393-d5c33a1f0255")).ao();
				cd3 = new EntityAspectReference<cd0, cd0>(serviceOrThrow.aqu().v().b().Area, new Guid("bc8a5a00-e665-4269-8705-c5aed5fc7b9f")).ao();
			}
			else
			{
				cd = new EntityAspectReference<cd0, cd0>(serviceOrThrow.aqu().v().b().Area, new Guid("10b3f0ab-5f6d-4fee-86cb-c388d27426eb")).ao();
				cd2 = new EntityAspectReference<cd0, cd0>(serviceOrThrow.aqu().v().b().Area, new Guid("22ccc11e-8d74-4db9-93db-33774911d734")).ao();
				cd3 = new EntityAspectReference<cd0, cd0>(serviceOrThrow.aqu().v().b().Area, new Guid("3e214c75-7864-43fc-9130-3bf988cf86a3")).ao();
			}
			if (cd != null && cd2 != null && cd3 != null)
			{
				double num = bnx.a(cd.a8().Location.b(), new Vector2(cd.a8().Location.X, 0f), serviceOrThrow.aqu().v().b().aj().b());
				double num2;
				if (num > 90.0)
				{
					num2 = 90.0 - (num - 90.0);
				}
				else
				{
					num2 = num;
				}
				if (num2 > 45.0)
				{
					num2 = 45.0 - (num2 - 45.0);
				}
				double num3 = aw1.b(cd3.a8(), serviceOrThrow.aqu().v().b());
				double num4 = 0.3 + num2 / 45.0 * 0.7;
				double num5 = 1.0 - num2 / 45.0;
				double num6 = d05.b(0.5, 1.0 - (num3 - 5.0) / 10.0, 1.0);
				cd.d = new float?((float)num4);
				cd2.d = new float?((float)num5);
				cd3.d = new float?((float)num6);
			}
		}
	}
}
