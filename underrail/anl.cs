using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020000C2 RID: 194
[eiz("PQ")]
[Serializable]
public class anl : ISerializable
{
	// Token: 0x06000455 RID: 1109 RVA: 0x00013F20 File Offset: 0x00012120
	protected anl(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.a = (Point)A_0.GetValue("PQ:N", typeof(Point));
			this.b = A_0.GetSingle("PQ:D");
			this.c = (ut)A_0.GetValue("PQ:RC", typeof(ut));
			this.d = (bde)A_0.GetValue("PQ:FC", typeof(bde));
			return;
		}
		if (base.GetType() == typeof(anl))
		{
			this.a = (Point)A_0.GetValue("_Node", typeof(Point));
			this.b = A_0.GetSingle("_Distance");
			this.c = (ut)A_0.GetValue("_RayContext", typeof(ut));
			this.d = (bde)A_0.GetValue("_FieldContext", typeof(bde));
			return;
		}
		this.a = (Point)A_0.GetValue("PredicateQuery+_Node", typeof(Point));
		this.b = A_0.GetSingle("PredicateQuery+_Distance");
		this.c = (ut)A_0.GetValue("PredicateQuery+_RayContext", typeof(ut));
		this.d = (bde)A_0.GetValue("PredicateQuery+_FieldContext", typeof(bde));
	}

	// Token: 0x06000456 RID: 1110 RVA: 0x000140AC File Offset: 0x000122AC
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("PQ:N", this.a);
		info.AddValue("PQ:D", this.b);
		info.AddValue("PQ:RC", this.c);
		info.AddValue("PQ:FC", this.d);
	}

	// Token: 0x06000457 RID: 1111 RVA: 0x00014104 File Offset: 0x00012304
	public Point d()
	{
		return this.a;
	}

	// Token: 0x06000458 RID: 1112 RVA: 0x0001410C File Offset: 0x0001230C
	public void a(Point A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000459 RID: 1113 RVA: 0x00014118 File Offset: 0x00012318
	public float a()
	{
		return this.b;
	}

	// Token: 0x0600045A RID: 1114 RVA: 0x00014120 File Offset: 0x00012320
	public void a(float A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600045B RID: 1115 RVA: 0x0001412C File Offset: 0x0001232C
	public ut b()
	{
		return this.c;
	}

	// Token: 0x0600045C RID: 1116 RVA: 0x00014134 File Offset: 0x00012334
	public void a(ut A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600045D RID: 1117 RVA: 0x00014140 File Offset: 0x00012340
	public bde c()
	{
		return this.d;
	}

	// Token: 0x0600045E RID: 1118 RVA: 0x00014148 File Offset: 0x00012348
	public void a(bde A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600045F RID: 1119 RVA: 0x00014154 File Offset: 0x00012354
	public anl()
	{
	}

	// Token: 0x06000460 RID: 1120 RVA: 0x00014160 File Offset: 0x00012360
	public anl(Point A_0, float A_1, ut A_2, bde A_3)
	{
		this.a(A_0);
		this.a(A_1);
		this.a(A_2);
		this.a(A_3);
	}

	// Token: 0x04000442 RID: 1090
	private Point a;

	// Token: 0x04000443 RID: 1091
	private float b;

	// Token: 0x04000444 RID: 1092
	private ut c;

	// Token: 0x04000445 RID: 1093
	private bde d;
}
