using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000A45 RID: 2629
[eiz("FSFLJ")]
[Serializable]
public sealed class egz : cze, ISerializable
{
	// Token: 0x06003E47 RID: 15943 RVA: 0x00177E24 File Offset: 0x00176024
	private egz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (Vector3)A_0.GetValue("FSFLJ:L", typeof(Vector3));
		this.a = (string)A_0.GetValue("FSFLJ:D", typeof(string));
	}

	// Token: 0x06003E48 RID: 15944 RVA: 0x00177E7C File Offset: 0x0017607C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("FSFLJ:L", this.b);
		info.AddValue("FSFLJ:D", this.a);
	}

	// Token: 0x06003E49 RID: 15945 RVA: 0x00177EB0 File Offset: 0x001760B0
	public Vector3 a()
	{
		return this.b;
	}

	// Token: 0x06003E4A RID: 15946 RVA: 0x00177EB8 File Offset: 0x001760B8
	public void a(Vector3 A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06003E4B RID: 15947 RVA: 0x00177EC4 File Offset: 0x001760C4
	public string b()
	{
		return this.a;
	}

	// Token: 0x06003E4C RID: 15948 RVA: 0x00177ECC File Offset: 0x001760CC
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003E4D RID: 15949 RVA: 0x00177ED8 File Offset: 0x001760D8
	public egz()
	{
	}

	// Token: 0x06003E4E RID: 15950 RVA: 0x00177EE0 File Offset: 0x001760E0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = new ar7(new Guid("e44d3a72-2886-44cd-910d-aa29e2666091"), A_0.Area).ao() as c5x;
		c5x.Zone.g(this.b());
		c5x.z = new Vector2?(new Vector2(0f, 0f));
		c5x.x = false;
		c5x.IsFloor = true;
		c5x.VisualPriority = -10;
		string text = this.b();
		float z;
		if (!(text == "Fatso_KillEast"))
		{
			if (!(text == "Fatso_KillSouth"))
			{
				z = -1f;
			}
			else
			{
				z = 0.3f;
			}
		}
		else
		{
			z = 0.25f;
		}
		awx awx = new awx();
		awx.b(false);
		awx.c(false);
		awx.a(false);
		c5x.i.b.a(true, false);
		awx.ad().Add(new a4s(new clv(false), null, new ar7(c5x), null));
		List<auv> list = awx.ad();
		aud a_ = c5x.Area;
		Vector3 a_2 = c5x.Location;
		string a_3 = "Smoke";
		int a_4 = 1;
		double maxValue = double.MaxValue;
		float? a_5 = dz6.b();
		list.Add(new au0(a_, a_2, a_3, a_4, maxValue, null, null, a_5));
		awx.ad().Add(new a4s(new bfq("PigAttack"), null, new ar7(c5x), null));
		awx.ad().Add(new a4s(new epw(new CharacterState?(CharacterState.Custom2)), null, new ar7(c5x), null));
		awx.ad().Add(new a4s(new b16(new int?(1)), null, new ar7(c5x), null));
		awx.ad().Add(new a4s(new cct("УВИ-и-и-и-и-и...", true, null, bvl.c), null, new ar7(c5x), null));
		List<auv> list2 = awx.ad();
		bpr bpr = new bpr(c5x.j.b, new Vector3(this.a().X, this.a().Y, z));
		bpr.a(false);
		list2.Add(bpr);
		List<auv> list3 = awx.ad();
		a4s a4s = new a4s(new be6
		{
			DestinationWaypoint = this.a
		}, null, null, null);
		a4s.a(new ar7(c5x));
		list3.Add(a4s);
		List<auv> list4 = awx.ad();
		cav cav = new cav();
		cav.a(650);
		cav.a(new int?(2));
		cav.e(new int?(2));
		cav.d(new int?(-2));
		cav.c(new int?(-2));
		list4.Add(new a4s(cav, null, null, null));
		c5x.i.b.b(awx, atp.a);
	}

	// Token: 0x04001BB4 RID: 7092
	private new string a;

	// Token: 0x04001BB5 RID: 7093
	private Vector3 b;
}
