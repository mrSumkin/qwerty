using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;

namespace TimelapseVertigo.Common.Data
{
	// Token: 0x02002225 RID: 8741
	[eiz("BV")]
	[Serializable]
	public class BoundVariable<T> : IBoundVariable<T>, ISerializable where T : struct
	{
		// Token: 0x0600CADF RID: 51935 RVA: 0x0047D480 File Offset: 0x0047B680
		protected BoundVariable(SerializationInfo A_0, StreamingContext A_1)
		{
			if (ell.a() != 0)
			{
				this.a = (T)((object)A_0.GetValue("BV:MX", typeof(T)));
				this.b = (T)((object)A_0.GetValue("BV:MN", typeof(T)));
				this.c = (T)((object)A_0.GetValue("BV:V", typeof(T)));
				if (ell.a() >= 4)
				{
					di7.ReadEvent<c1>("BV:eVC", ref this.d, A_0);
					di7.ReadEvent<c1>("BV:eMXC", ref this.e, A_0);
					di7.ReadEvent<c1>("BV:eMIC", ref this.f, A_0);
					return;
				}
			}
			else
			{
				if (base.GetType() == typeof(BoundVariable<T>))
				{
					this.a = (T)((object)A_0.GetValue("_Maximum", typeof(T)));
					this.b = (T)((object)A_0.GetValue("_Minimum", typeof(T)));
					this.c = (T)((object)A_0.GetValue("_Value", typeof(T)));
					return;
				}
				this.a = (T)((object)A_0.GetValue("BoundVariable`1+_Maximum", typeof(T)));
				this.b = (T)((object)A_0.GetValue("BoundVariable`1+_Minimum", typeof(T)));
				this.c = (T)((object)A_0.GetValue("BoundVariable`1+_Value", typeof(T)));
			}
		}

		// Token: 0x0600CAE0 RID: 51936 RVA: 0x0047D618 File Offset: 0x0047B818
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("BV:MX", this.a);
			info.AddValue("BV:MN", this.b);
			info.AddValue("BV:V", this.c);
			di7.WriteEvent<c1>("BV:eVC", this.d, info);
			di7.WriteEvent<c1>("BV:eMXC", this.e, info);
			di7.WriteEvent<c1>("BV:eMIC", this.f, info);
		}

		// Token: 0x0600CAE1 RID: 51937 RVA: 0x0047D69C File Offset: 0x0047B89C
		public T zo()
		{
			return this.c;
		}

		// Token: 0x0600CAE2 RID: 51938 RVA: 0x0047D6A8 File Offset: 0x0047B8A8
		public void zp(T A_0)
		{
			T t = this.c;
			this.c = A_0;
			if (Comparer<T>.Default.Compare(this.c, this.a) > 0)
			{
				this.c = this.a;
			}
			else if (Comparer<T>.Default.Compare(this.c, this.b) < 0)
			{
				this.c = this.b;
			}
			if (!this.c.Equals(t) && this.d != null)
			{
				this.d(this, new c1(t, this.c));
			}
		}

		// Token: 0x0600CAE3 RID: 51939 RVA: 0x0047D764 File Offset: 0x0047B964
		public T zm()
		{
			return this.a;
		}

		// Token: 0x0600CAE4 RID: 51940 RVA: 0x0047D770 File Offset: 0x0047B970
		public void zn(T A_0)
		{
			if (!this.a.Equals(A_0))
			{
				T t = this.a;
				this.a = A_0;
				if (this.e != null)
				{
					this.e(this, new c1(t, A_0));
				}
				if (Comparer<T>.Default.Compare(this.c, this.a) > 0)
				{
					this.zp(this.a);
				}
			}
		}

		// Token: 0x0600CAE5 RID: 51941 RVA: 0x0047D7F8 File Offset: 0x0047B9F8
		public T zk()
		{
			return this.b;
		}

		// Token: 0x0600CAE6 RID: 51942 RVA: 0x0047D804 File Offset: 0x0047BA04
		public void zl(T A_0)
		{
			if (!this.b.Equals(A_0))
			{
				T t = this.b;
				this.b = A_0;
				if (this.f != null)
				{
					this.f(this, new c1(t, A_0));
				}
				if (Comparer<T>.Default.Compare(this.c, this.b) < 0)
				{
					this.zp(this.b);
				}
			}
		}

		// Token: 0x0600CAE7 RID: 51943 RVA: 0x0047D88C File Offset: 0x0047BA8C
		[CompilerGenerated]
		public void zq(EventHandler<c1> A_0)
		{
			EventHandler<c1> eventHandler = this.d;
			EventHandler<c1> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
				eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.d, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x0600CAE8 RID: 51944 RVA: 0x0047D8C4 File Offset: 0x0047BAC4
		[CompilerGenerated]
		public void zr(EventHandler<c1> A_0)
		{
			EventHandler<c1> eventHandler = this.d;
			EventHandler<c1> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
				eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.d, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x0600CAE9 RID: 51945 RVA: 0x0047D8FC File Offset: 0x0047BAFC
		[CompilerGenerated]
		public void zs(EventHandler<c1> A_0)
		{
			EventHandler<c1> eventHandler = this.e;
			EventHandler<c1> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
				eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.e, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x0600CAEA RID: 51946 RVA: 0x0047D934 File Offset: 0x0047BB34
		[CompilerGenerated]
		public void zt(EventHandler<c1> A_0)
		{
			EventHandler<c1> eventHandler = this.e;
			EventHandler<c1> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
				eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.e, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x0600CAEB RID: 51947 RVA: 0x0047D96C File Offset: 0x0047BB6C
		[CompilerGenerated]
		public void zu(EventHandler<c1> A_0)
		{
			EventHandler<c1> eventHandler = this.f;
			EventHandler<c1> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
				eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.f, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x0600CAEC RID: 51948 RVA: 0x0047D9A4 File Offset: 0x0047BBA4
		[CompilerGenerated]
		public void zv(EventHandler<c1> A_0)
		{
			EventHandler<c1> eventHandler = this.f;
			EventHandler<c1> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
				eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.f, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x0600CAED RID: 51949 RVA: 0x0047D9DC File Offset: 0x0047BBDC
		public BoundVariable()
		{
		}

		// Token: 0x0600CAEE RID: 51950 RVA: 0x0047D9E4 File Offset: 0x0047BBE4
		public BoundVariable(T A_0, T A_1)
		{
			this.c = A_0;
			this.a = A_1;
		}

		// Token: 0x04004A8D RID: 19085
		private T a;

		// Token: 0x04004A8E RID: 19086
		private T b;

		// Token: 0x04004A8F RID: 19087
		private T c;

		// Token: 0x04004A90 RID: 19088
		[CompilerGenerated]
		private EventHandler<c1> d;

		// Token: 0x04004A91 RID: 19089
		[CompilerGenerated]
		private EventHandler<c1> e;

		// Token: 0x04004A92 RID: 19090
		[CompilerGenerated]
		private EventHandler<c1> f;
	}
}
