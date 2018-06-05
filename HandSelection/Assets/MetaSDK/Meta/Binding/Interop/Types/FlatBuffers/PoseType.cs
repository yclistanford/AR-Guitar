﻿// Copyright © 2018, Meta Company.  All rights reserved.
// 
// Redistribution and use of this software (the "Software") in binary form, without modification, is 
// permitted provided that the following conditions are met:
// 
// 1.      Redistributions of the unmodified Software in binary form must reproduce the above 
//         copyright notice, this list of conditions and the following disclaimer in the 
//         documentation and/or other materials provided with the distribution.
// 2.      The name of Meta Company (“Meta”) may not be used to endorse or promote products derived 
//         from this Software without specific prior written permission from Meta.
// 3.      LIMITATION TO META PLATFORM: Use of the Software is limited to use on or in connection 
//         with Meta-branded devices or Meta-branded software development kits.  For example, a bona 
//         fide recipient of the Software may incorporate an unmodified binary version of the 
//         Software into an application limited to use on or in connection with a Meta-branded 
//         device, while he or she may not incorporate an unmodified binary version of the Software 
//         into an application designed or offered for use on a non-Meta-branded device.
// 
// For the sake of clarity, the Software may not be redistributed under any circumstances in source 
// code form, or in the form of modified binary code – and nothing in this License shall be construed 
// to permit such redistribution.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDER "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, 
// INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A 
// PARTICULAR PURPOSE ARE DISCLAIMED.  IN NO EVENT SHALL META COMPANY BE LIABLE FOR ANY DIRECT, 
// INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, 
// PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA OR PROFITS; OR BUSINESS 
// INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT 
// LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS 
// SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
// automatically generated by the FlatBuffers compiler, do not modify

namespace types.fbs
{

using System;
using FlatBuffers;

public struct PoseType : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static PoseType GetRootAsPoseType(ByteBuffer _bb) { return GetRootAsPoseType(_bb, new PoseType()); }
  public static PoseType GetRootAsPoseType(ByteBuffer _bb, PoseType obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public PoseType __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public types.fbs.BufferHeader? Header { get { int o = __p.__offset(4); return o != 0 ? (types.fbs.BufferHeader?)(new types.fbs.BufferHeader()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public string Source { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetSourceBytes() { return __p.__vector_as_arraysegment(6); }
  public string Target { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetTargetBytes() { return __p.__vector_as_arraysegment(8); }
  public types.fbs.Vector3d? Position { get { int o = __p.__offset(10); return o != 0 ? (types.fbs.Vector3d?)(new types.fbs.Vector3d()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public types.fbs.Quaterniond? Orientation { get { int o = __p.__offset(12); return o != 0 ? (types.fbs.Quaterniond?)(new types.fbs.Quaterniond()).__assign(o + __p.bb_pos, __p.bb) : null; } }

  public static void StartPoseType(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddHeader(FlatBufferBuilder builder, Offset<types.fbs.BufferHeader> headerOffset) { builder.AddOffset(0, headerOffset.Value, 0); }
  public static void AddSource(FlatBufferBuilder builder, StringOffset sourceOffset) { builder.AddOffset(1, sourceOffset.Value, 0); }
  public static void AddTarget(FlatBufferBuilder builder, StringOffset targetOffset) { builder.AddOffset(2, targetOffset.Value, 0); }
  public static void AddPosition(FlatBufferBuilder builder, Offset<types.fbs.Vector3d> positionOffset) { builder.AddStruct(3, positionOffset.Value, 0); }
  public static void AddOrientation(FlatBufferBuilder builder, Offset<types.fbs.Quaterniond> orientationOffset) { builder.AddStruct(4, orientationOffset.Value, 0); }
  public static Offset<PoseType> EndPoseType(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<PoseType>(o);
  }
  public static void FinishPoseTypeBuffer(FlatBufferBuilder builder, Offset<PoseType> offset) { builder.Finish(offset.Value); }
};


}
